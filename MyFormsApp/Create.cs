using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFormsApp
{

    public partial class Create : Form
    {
        private const string DbFileName = "infodb.db";


        //public static char cSharpComboBoxContent, javaComboBoxContent, phpComboBoxContent;
        public static string cSharpComboBoxContent, javaComboBoxContent, phpComboBoxContent;

        public Create()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //******************************
        // ClearForm() is intented to clear textfields and selections.
        //******************************
        private void ClearForm()
        {

            nameTextBox.Text = "";
            idTextBox.Text = "";
            dobPicker.Text = "";
            phoneTextBox.Text = "";
            emailTextBox.Text = "";
            foreach (Control control in genderPanel.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
            pwdCheckBox.Checked = false;
            cSharpComboBox.Text = "";
            javaComboBox.Text = "";
            phpComboBox.Text = "";
            cgpaTextBox.Text = "";
 }

        //******************************
        // submitButton_Click passes the data to be entered into insert into the database.
        //******************************
        private void submitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World!");

            if (cSharpComboBox?.SelectedItem != null)
            {
                cSharpComboBoxContent = cSharpComboBox.SelectedItem.ToString();
            }
            else
            {
                cSharpComboBoxContent = string.Empty; // or handle as needed
            }

            if (javaComboBox?.SelectedItem != null)
            {
                javaComboBoxContent = javaComboBox.SelectedItem.ToString();
            }
            else
            {
                javaComboBoxContent = string.Empty;
            }

            if (phpComboBox?.SelectedItem != null)
            {
                phpComboBoxContent = phpComboBox.SelectedItem.ToString();
            }
            else
            {
                phpComboBoxContent = string.Empty;
            }
            // ? is the null-conditional operator (?.) in C#. It helps you safely access properties or methods on objects that might be null, without throwing a NullReferenceException.

            getGradePoint gpObj = new getGradePoint();

            decimal cgpa = (gpObj.getPoint(cSharpComboBoxContent) + gpObj.getPoint(javaComboBoxContent) + gpObj.getPoint(phpComboBoxContent)) / 3;
            cgpa = (decimal)Math.Round(cgpa, 2);
            cgpaTextBox.Text = cgpa.ToString(); ;
            Console.WriteLine("C# Grade is " + cSharpComboBoxContent + "\ncgpa = " + cgpa);

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(idTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please fill Name, id, email and Mobile fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var name = nameTextBox.Text.Trim();
            var id = idTextBox.Text.Trim();
            var dob = dobPicker.Value.ToString("yyyy-MM-dd");
            var email = emailTextBox.Text.Trim();
            var phone = phoneTextBox.Text.Trim();
            //var email = txtEmail.Text.Trim();
            var gender = "";
            //if (femaleRadio.Checked){
            //    gender = "F";
            //}
            //if (maleRadio.Checked)
            //{
            //    gender = "M";
            //}
            //if (otherRadio.Checked)
            //{
            //    gender = "O";
            //}
            gender = maleRadio.Checked ? "Male" : femaleRadio.Checked ? "Female" : otherRadio.Checked ? "Other" : string.Empty;

            int pwd = 0;
            if (pwdCheckBox.Checked)
            {
                pwd = 1;
            }

            //var address = txtAddress.Text.Trim();
            //var cSharp = cSharpComboBox.SelectedItem?.ToString() ?? string.Empty;
            //var java = javaComboBox.SelectedItem?.ToString() ?? string.Empty;
            //var php = phpComboBox.SelectedItem?.ToString() ?? string.Empty;


            decimal cSharp = 0, java = 0, php = 0;
            //decimal.TryParse(cSharpComboBox.SelectedItem?.ToString(), out cSharp);
            //decimal.TryParse(javaComboBox.SelectedItem?.ToString(), out java);
            //decimal.TryParse(phpComboBox.SelectedItem?.ToString(), out php);

            cSharp = gpObj.getPoint(cSharpComboBoxContent);
            java = gpObj.getPoint(javaComboBoxContent);
            php = gpObj.getPoint(phpComboBoxContent);

            //decimal cgpa = decimal.Parse(cgpaTextBox.Text.Trim());


            try
            {
                SaveToDatabase(name, id, dob, email, phone, gender, pwd, cSharp, java, php, cgpa);
                MessageBox.Show("Registered Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving registration:\n{ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                SaveToDatabase(name, id, dob, email, phone, gender, pwd, cSharp, java, php, cgpa);
                MessageBox.Show("Registered Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving registration:\n{ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //******************************
        // SaveToDatabase() inserts the data received on submitButton_Click to the database.
        //******************************
        private void SaveToDatabase(
            string name,
            string id,
            string dob,
            string email,
            string phone,
            string gender,
            int pwd,
            decimal cSharp,
            decimal java,
            decimal php,
            decimal cgpa)
        {
            // Build connection string (file is auto-created)
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DbFileName);
            var connString = new SQLiteConnectionStringBuilder
            {
                DataSource = dbPath,
                Version = 3
            }.ToString();

            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();

                // 1) Create table if missing
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                      CREATE TABLE IF NOT EXISTS Registrations (
    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
    StudentId  TEXT    NOT NULL UNIQUE,  -- corresponds to `string id`
    Name       TEXT    NOT NULL,
    DOB        TEXT    NOT NULL,
    Email      TEXT    NOT NULL UNIQUE,
    Phone      TEXT    NOT NULL,
    Gender     TEXT,
    Pwd        INTEGER NOT NULL,         -- corresponds to `int pwd`
    CSharp     REAL    NOT NULL,         -- corresponds to `decimal cSharp`
    Java       REAL    NOT NULL,         -- corresponds to `decimal java`
    Php        REAL    NOT NULL,         -- corresponds to `decimal php`
    Cgpa       REAL    NOT NULL,         -- corresponds to `decimal cgpa`
    CreatedAt  TEXT    NOT NULL
);
";
                    cmd.ExecuteNonQuery();
                }

                // 1) Create table if missing
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Photos(
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    ImageData BLOB
);";
                cmd.ExecuteNonQuery();
            }


            // 2) Insert the record
            using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
    INSERT INTO Registrations
        (StudentId, Name, DOB, Email, Phone, Gender, Pwd, CSharp, Java, Php, Cgpa, CreatedAt)
    VALUES
        (@studentId, @name, @dob, @email, @phone, @gender, @pwd, @cSharp, @java, @php, @cgpa, @createdAt);";


                    cmd.Parameters.AddWithValue("@studentId", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    cmd.Parameters.AddWithValue("@cSharp", cSharp);
                    cmd.Parameters.AddWithValue("@java", java);
                    cmd.Parameters.AddWithValue("@php", php);
                    cmd.Parameters.AddWithValue("@cgpa", cgpa);
                    cmd.Parameters.AddWithValue("@createdAt", DateTime.UtcNow.ToString("o"));


                    cmd.ExecuteNonQuery();
                }

                //******************************
                //
                //******************************
                //byte[] imageBytes = ImageToByteArray(image);

                //using (SQLiteConnection connec = new SQLiteConnection("Data Source=mydatabase.db"))
                ////using (var cmd = conn.CreateCommand())
                //{
                //    conn.Open();
                //    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Photos (ImageData) VALUES (@Image)", connec))
                //    {
                //        cmd.Parameters.AddWithValue("@Image", imageBytes);
                //        cmd.ExecuteNonQuery();
                //    }
                //}



            }
        }


        
        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //******************************
        // phoneTextBox_KeyPress here validates that the entered phone number is not more than 10 digits
        //******************************
        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phoneTextBox.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mobile number cannot be more than 10 digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        //******************************
        // clearButton_Click uses ClearForm() to clear textfields and selections.
        //******************************
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void otherRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        //******************************
        // textBox1_TextChanged_1 validates whether the entered text has a valid email format using the method IsValidEmail().
        //******************************
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //{
                string email = emailTextBox.Text.Trim();

                if (IsValidEmail(email))
                {
                    lblResult.Text = "✅ Valid email";
                    lblResult.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblResult.Text = "❌ Invalid email";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }

            //}
        }

        //******************************
        // IsValidEmail() is a method to check whether the entered text has a valid email format.
        //******************************
        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        private void cSharpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //******************************
        // displayButton_Click opens the Display window by creating and using an instance of Display().
        //******************************
        private void displayButton_Click(object sender, EventArgs e)
        {
            Display disp1 = new Display();
            //disp1.Show();
            disp1.ShowDialog();
            //this.Hide();
        }

        //OpenFileDialog photoOpenFileDialog = new OpenFileDialog();

        //******************************
        // Drag and droped OpenFileDialog from toolbox, to upload image.
        //******************************
        private void photoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog photoOpenFileDialog = new OpenFileDialog())
            { 
                if (photoOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string selectedFile = photoOpenFileDialog.FileName;
                    photoBox.Image = System.Drawing.Image.FromFile(selectedFile);
                    //******************************
                    // The size mode property of photoBox was set to zoom.
                    //******************************

                }
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image photoBoxPicture)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                photoBoxPicture.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // or .Jpeg
                return ms.ToArray();
            }
        }
        public void SaveImageToDatabase(System.Drawing.Image image)
        {
            byte[] imageBytes = ImageToByteArray(image);

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=mydatabase.db"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Photos (ImageData) VALUES (@Image)", conn))
                {
                    cmd.Parameters.AddWithValue("@Image", imageBytes);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    } 
}


public class getGradePoint
    {
    //******************************
    //The method getPoint receives the grade of a subject as parameter and  returns the corresponding grade point.
    //******************************
    public decimal getPoint(String grade)
        {

            decimal point = 0;
            if (grade == "A")
            {
                point = 5;
            }
            else if (grade == "B")
            {
                point = 4;
            }
            else if (grade == "C")
            {
                point = 3;
            }
            else if (grade == "D")
            {
                point = 2;
            }
            else if (grade == "E")
            {
                point = 1;
            }

            return point;

            //Form1 formObj = new Form1();
            //Console.WriteLine("Java Grade is " + Form1.javaComboBoxContent);
        }

      
    }


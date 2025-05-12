using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SQLite;
using System.IO;
using System.Net.Mail;

namespace MyFormsApp
{
    public partial class Update : Form
    {
        private const string DbFileName = "infodb.db";
        public string StudentIdToLoad { get; set; }



        public static string cSharpComboBoxContent, javaComboBoxContent, phpComboBoxContent;
        public Update()
        {
            InitializeComponent();
            this.Load += Update_Load;

        }

        private void Update_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(StudentIdToLoad))
            {
                LoadStudentData(StudentIdToLoad);
            }
        }

        private void LoadStudentData(string studentId)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DbFileName);
            var connString = new SQLiteConnectionStringBuilder { DataSource = dbPath, Version = 3 }.ToString();

            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Registrations WHERE StudentId = @studentId";
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idTextBox.Text = reader["StudentId"].ToString();
                            nameTextBox.Text = reader["Name"].ToString();
                            dobPicker.Value = DateTime.Parse(reader["DOB"].ToString());
                            emailTextBox.Text = reader["Email"].ToString();
                            phoneTextBox.Text = reader["Phone"].ToString();

                            var gender = reader["Gender"].ToString();
                            if (gender == "Male") maleRadio.Checked = true;
                            else if (gender == "Female") femaleRadio.Checked = true;
                            else if (gender == "Other") otherRadio.Checked = true;

                            pwdCheckBox.Checked = Convert.ToInt32(reader["Pwd"]) == 1;

          

                            getGrade gLetter = new getGrade();

                            decimal cSharpPoint = Convert.ToDecimal(reader["CSharp"]);
                            decimal javaPoint = Convert.ToDecimal(reader["Java"]);
                            decimal phpPoint = Convert.ToDecimal(reader["Php"]);

                            cSharpComboBox.SelectedItem = gLetter.getGradeLetter(cSharpPoint);
                            javaComboBox.SelectedItem = gLetter.getGradeLetter(javaPoint);
                            phpComboBox.SelectedItem = gLetter.getGradeLetter(phpPoint);



                            cgpaTextBox.Text = reader["Cgpa"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Student not found.");
                        }
                    }
                }
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
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
        }
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

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
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



        //private void submitButton_Click(object sender, EventArgs e)
        //{

        //}

        private void updtBtn_Click(object sender, EventArgs e)
        {
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

            var gender = "";

            gender = maleRadio.Checked ? "Male" : femaleRadio.Checked ? "Female" : otherRadio.Checked ? "Other" : string.Empty;

            int pwd = 0;
            if (pwdCheckBox.Checked)
            {
                pwd = 1;
            }

            decimal cSharp = 0, java = 0, php = 0;

            cSharp = gpObj.getPoint(cSharpComboBoxContent);
            java = gpObj.getPoint(javaComboBoxContent);
            php = gpObj.getPoint(phpComboBoxContent);



            try
            {
                SaveToDatabase(name, id, dob, email, phone, gender, pwd, cSharp, java, php, cgpa);
                MessageBox.Show("Update Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving registration:\n{ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
    UPDATE Registrations SET
        Name = @name,
        DOB = @dob,
        Email = @email,
        Phone = @phone,
        Gender = @gender,
        Pwd = @pwd,
        CSharp = @cSharp,
        Java = @java,
        Php = @php,
        Cgpa = @cgpa,
        CreatedAt = @createdAt
    WHERE StudentId = @studentId;";



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
            
        }
        }
    }
}
public class getGrade
{

    //The method getPoint receives the grade of a subject as parameter
    //and  returns the corresponding grade point.
    public string getGradeLetter(decimal point)
    {

        //decimal point = 0;
        string grade = "X";
        if (point == 5)
        {
            grade = "A";
        }
        else if (point == 4)
        {
            grade = "B";
        }
        else if (point == 3)
        {
            grade = "C";
        }
        else if (point == 2)
        {
            grade = "D";
        }
        else if (point == 1)
        {
            grade = "E";
        }

        return grade;

    }


}

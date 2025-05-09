using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Data;
//using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace MyFormsApp
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Display_Load);

        }

        private void Display_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=infodb.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Registrations";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                // Now bind `dt` to your DataGridView or controls
                mainDataGridView.DataSource = dt;
            }
        }

        private void mainDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.mainDataGridView.SelectedRows.Count > 0)
            {
                if (mainDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = mainDataGridView.SelectedRows[0];

                    // Assuming 'Id' is your primary key
                    int idToDelete = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    // Delete from database
                    string connectionString = "Data Source=infodb.db;Version=3;";
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM Registrations WHERE Id = @id";
                        SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", idToDelete);
                        cmd.ExecuteNonQuery();
                    }

                    mainDataGridView.Rows.RemoveAt(this.mainDataGridView.SelectedRows[0].Index);
                }
            }
        }
    }
}



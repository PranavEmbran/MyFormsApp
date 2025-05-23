#region File Header
/*
Copyright Hodo. 2025
All rights are reserved. Reproduction or transmission in whole or in part, in any form or by any means, electronic, mechanical or otherwise, is prohibited without the prior written consent of the copyright owner.
File Name  :Display.cs
Description  :Display data from database to form.
Log
Date              Author        Comment
15-05-2025        Pranav        Read the content from db and display it in the form.
*/
#endregion

#region
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

#endregion

//using System.Data;
//using System.Data.SqlClient;
//using System.Data.SQLite;
using System.Data.SqlClient;

namespace MyFormsApp
{
    public partial class Display : Form
    {
        public static string filterByCGPAComboBoxContent = "ALL";
        public Display()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Display_Load);


        }

        //******************************
        // Display_Load method uses Load_Data() method to fetche data from the database and bind/show it in the DataGridView.
        //******************************
        private void Display_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        //******************************
        //Load_Data() method to fetches data from the database and binds/shows it in the DataGridView.
        //******************************
        //private void Load_Data()
        //{
        //    string connectionString = "Data Source=infodb.db;Version=3;";
        //    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM Registrations";
        //        SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        // Now bind `dt` to your DataGridView or controls
        //        mainDataGridView.DataSource = dt;
        //    }
        //}

        //******************************
        //Load_Data() method to fetches data from the database and binds/shows it in the DataGridView.
        //******************************
        private void Load_Data()
        {
            string connectionString = "Data Source=infodb.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query;

                if (filterByCGPAComboBoxContent == "5")
                {
                    query = "SELECT * FROM Registrations WHERE Cgpa = 5";
                }
                else if (filterByCGPAComboBoxContent == ">=4")
                {
                    query = "SELECT * FROM Registrations WHERE Cgpa >= 4";
                }
                else if (filterByCGPAComboBoxContent == ">=3")
                {
                    query = "SELECT * FROM Registrations WHERE Cgpa >= 3";
                }
                else if (filterByCGPAComboBoxContent == ">=2")
                {
                    query = "SELECT * FROM Registrations WHERE Cgpa >= 2";
                }
                else if (filterByCGPAComboBoxContent == ">=1")
                {
                    query = "SELECT * FROM Registrations WHERE Cgpa >= 1";
                }
                else if (filterByCGPAComboBoxContent == "0")
                {
                    query = "SELECT * FROM Registrations WHERE Cgpa = 0";
                }
                else 
                {
                    query = "SELECT * FROM Registrations"; 
                }
                    
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

        //******************************
        // deleteRowButton_Click deletes the row selected in theDataGridView from the database.
        //******************************
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

        //******************************
        // updateBtn_Click opens the Update window while passing the StudentId of the selected row to Update().
        //******************************
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Update updt1 = new Update();
            //updt1.ShowDialog();
            if (mainDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = mainDataGridView.SelectedRows[0];
                string studentId = selectedRow.Cells["StudentId"].Value.ToString();

                var updateForm = new Update();
                updateForm.StudentIdToLoad = studentId;
                updateForm.ShowDialog();

                Load_Data();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        //******************************
        // filterByGradeComboBox_SelectedIndexChanged() Loads/refreshes the data grid and
        // updates the static variable filterByCGPAComboBoxContent,
        // each time the combobox selection is changed.
        //******************************
        private void filterByGradeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (filterByCGPAComboBox?.SelectedItem != null)
            {
                filterByCGPAComboBoxContent = filterByCGPAComboBox.SelectedItem.ToString();
                Load_Data();

            }
            else
            {
                //filterByCGPAComboBoxContent = string.Empty;
                filterByCGPAComboBoxContent = "ALL";
            }
        }

        private void filterByGradeLabel_Click(object sender, EventArgs e)
        {

        }

        private void pdfBtn_Click(object sender, EventArgs e)
        {
            //MyFormsApp.GetDbinPdf.getPdf.GeneratePdf();
            getPdf.GeneratePdf();
        }
    }
}



using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.SQLite;



using System.Data.SQLite;
using System.Windows.Forms;


//public class Class1
//{
//	public Class1()
//	{
//	}
//}

namespace MyFormsApp
{
    public class getPdf
    {
        //public static void Main()
        public static void GeneratePdf()
        {
            //public getPdf() {
            string outputPath = "registrations.pdf";
            //string outputPath = @"C:\Users\Pranav\Documents\sample.pdf";
            //string dbPath = "infodb.db";
            string dbPath = @"C:\Users\Pranav\source\repos\MyFormsApp\bin\Debug\infodb.db";


            // Your DB connection string
            //string connectionString = "Server=YOUR_SERVER;Database=infodb;Trusted_Connection=True;";
            //string connectionString = "Server=localhost;Database=infodb;Trusted_Connection=True;";
            //var connectionString = new SQLiteConnectionStringBuilder
            string connectionString = $"Data Source={dbPath};Version=3;";

            // Your query
            //string query = "SELECT Id, Name, Email FROM Registrations";
            string query = "SELECT * FROM Registrations";


            // Fetch data
            DataTable dataTable = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }



            using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Step 1: Create Document
                //Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                Document doc = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30);


                // Step 2: Create PdfWriter
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                // Step 3: Open document
                doc.Open();

                // Step 4: Add content
                //doc.Add(new Paragraph("ID"));
                //doc.Add(new Paragraph("Name"));
                //doc.Add(new Paragraph("Email"));
                ////doc.Add(new Paragraph("Generated on: " + DateTime.Now));
                //doc.Add(new Paragraph("\n"));

                // Create PDF table with number of columns = dataTable columns
                PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);

                // Add headers
                foreach (DataColumn column in dataTable.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }

                // Add data rows
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        pdfTable.AddCell(item.ToString());
                    }
                }

                // Add table to document
                doc.Add(pdfTable);

                // Step 5: Close document
                doc.Close();
            }

            MessageBox.Show("PDF created successfully.");
            Console.WriteLine("PDF created successfully.");
        }
    }
}

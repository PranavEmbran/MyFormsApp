using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
        public static void Main()
        {
            //public getPdf() {
            string outputPath = "sample.pdf";
            //string outputPath = @"C:\Users\Pranav\Documents\sample.pdf";


            using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Step 1: Create Document
                Document doc = new Document(PageSize.A4, 50, 50, 50, 50);

                // Step 2: Create PdfWriter
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                // Step 3: Open document
                doc.Open();

                // Step 4: Add content
                doc.Add(new Paragraph("Hello, this is a PDF created using iTextSharp."));
                doc.Add(new Paragraph("Generated on: " + DateTime.Now));

                // Step 5: Close document
                doc.Close();
            }

            Console.WriteLine("PDF created successfully.");
        }
    }
}

using System;
namespace BuilderPattern
{
    public class PdfDocument
    {
        public PdfDocument()
        {
        }

        public void AddPage(string text)
        {
            Console.WriteLine("Adding a page to PDF");
        }
    }
}

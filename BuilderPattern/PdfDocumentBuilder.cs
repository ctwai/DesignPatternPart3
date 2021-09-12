using System;
namespace BuilderPattern
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private PdfDocument document = new PdfDocument();

        public void AddSlides(Slide slide)
        {
            document.AddPage(slide.GetText());
        }

        public PdfDocument GetPdfDocument()
        {
            return document;
        }
    }
}
                    
using System;

namespace BuilderPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // BuildPattern
            // To separate the construction of an object from its representation

            // in this example we separate the construction (export method) from the
            // type we want to export (concrete implementation) - like PDF/Excel/Word/Movie etc

            var presentation = new Presentation();
            presentation.AddSlide(new Slide("Slide 1"));
            presentation.AddSlide(new Slide("Slide 2"));

            //var builder = new MovieBuilder();
            //presentation.Export(builder);
            //var movie = builder.GetMovie();

            var builder = new PdfDocumentBuilder();
            presentation.Export(builder);
            var pdf = builder.GetPdfDocument();


            Console.ReadLine();
        }
    }
}

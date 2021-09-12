using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Presentation
    {
        // collection of slide

        private List<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }

        // Problem
        // 1.Violate open close principle - Need to update this class to support new format
        // 2. tight coupled between Presentation and PdfDocument/Movie
        // 3. Too many implementation knowledge of this class here - AddPage/AddFrame etc.
        // this class has so much knowledge of other classes method
        // 4. Repetition in the exporting logic - if I have to add a page with copyright in it
        // I have to do it in all the export type

        // Builder Pattern: To separate the construction of an object from its representation
        // In this example : To separate the exporting logic from presentation format (Same exporting logic apply to different presentation formats)

        // Goal : Separate the presentation logic (Create PDF/Movie) from the construction of an object (Export Method)

        public void Export(IPresentationBuilder builder)
        {
            //if (format == PresentationFormat.PDF)
            //{
            //    var pdf = new PdfDocument();
            //    foreach (var slide in slides)
            //        pdf.AddPage(slide.GetText());
            //}
            //else if (format == PresentationFormat.MOVIE)
            //{
            //    var movie = new Movie();
            //    foreach (var slide in slides)
            //        movie.AddFrame(slide.GetText(), 3);
            //}

            builder.AddSlides(new Slide("Copyright"));
            foreach (var slide in slides)
                builder.AddSlides(slide);

            
        }
       
    }
}

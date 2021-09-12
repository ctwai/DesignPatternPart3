using System;
namespace BuilderPattern
{
    public class MovieBuilder : IPresentationBuilder
    {
        private Movie movie = new Movie();

        public void AddSlides(Slide slide)
        {
            movie.AddFrame(slide.GetText(), 3);
        }

        public Movie GetMovie()
        {
            return movie;
        }
    }
}

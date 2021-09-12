using System;
namespace BuilderPattern
{
    public interface IPresentationBuilder
    {
        void AddSlides(Slide slide);
    }
}

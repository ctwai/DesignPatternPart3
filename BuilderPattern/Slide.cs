using System;
namespace BuilderPattern
{
    public class Slide
    {
        // assume we can only add text to slide for simplicity

        private string _text;

        public Slide(string text)
        {
            _text = text;
        }

        public string GetText()
        {
            return _text;
        }
    }
}

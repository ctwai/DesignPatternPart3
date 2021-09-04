using System;
namespace AbstractFactory.Ant
{
    public class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render from Ant Text Box");
        }
    }
}

using System;
namespace AbstractFactory.Material
{
    public class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Render from Material Text Box");
        }
    }
}

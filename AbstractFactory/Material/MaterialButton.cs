using System;
namespace AbstractFactory.Material
{
    public class MaterialButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render from Material Button");
        }
    }
}

using System;
namespace AbstractFactory.Ant
{
    public class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render from Ant Button");
        }
    }
}

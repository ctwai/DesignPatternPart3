using System;
using AbstractFactory.Ant;
using AbstractFactory.App;
using AbstractFactory.Material;

namespace AbstractFactory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Abstract Factory Pattern provides an interface for creating families of
            // related objects

            // Problem - we are trying to use two UI framework
            // Material and Ant to rend buttons in different framework
            // during run time.

            // new ContactForm().Render(new MaterialWidgetFactory());
            new ContactForm().Render(new AntWidgetFactory());
            Console.ReadKey();
        }
    }
}

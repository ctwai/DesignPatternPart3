using System;
using AbstractFactory.Ant;
using AbstractFactory.Material;

namespace AbstractFactory.App
{
    public class ContactForm
    {
        // Use can change the theme at runtime
        public void Render(IWidgetFactory factory)
        {
            factory.CreateButton().Render();
            factory.CreateTextBox().Render();
        }
    }
}

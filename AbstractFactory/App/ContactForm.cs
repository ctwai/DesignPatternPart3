using System;
using AbstractFactory.Ant;
using AbstractFactory.Material;

namespace AbstractFactory.App
{
    public class ContactForm
    {
        // Use can change the theme at runtime
        public void Render(Theme theme)
        {
            if (theme == Theme.Ant)
            {
                new AntTextBox().Render();
                new AntButton().Render();
            }
            else if (theme == Theme.Material)
            {
                new MaterialTextBox().Render();
                new MaterialButton().Render();
            }
        }
    }
}

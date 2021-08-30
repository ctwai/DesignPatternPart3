using System;
using System.Collections.Generic;

namespace FactoryMetthodPattern.Sharp
{
    public class SharpViewEngine : IViewEngine
    { 
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View Render by  Sharp";
        }
    }
}

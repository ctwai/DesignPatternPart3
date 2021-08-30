using System;
using System.Collections.Generic;

namespace FactoryMetthodPattern
{
    public class MatchaViewEngine : IViewEngine
    {
        // Extract the method here to interface so we can pass it as 
        // a parameter to the Controller class
        public string Render(String viewName, Dictionary<string, object> context)
        {
            return "View Return by Matcha";
        }
    }
}

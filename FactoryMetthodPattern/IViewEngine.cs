using System;
using System.Collections.Generic;

namespace FactoryMetthodPattern
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}

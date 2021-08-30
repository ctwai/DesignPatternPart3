using System;
using System.Collections.Generic;

namespace FactoryMetthodPattern
{
    public class Controller
    {
        public void Render(String viewName, Dictionary<string, object> context)
        {
            // Problem with this code.  If the other user want to replace
            // MatchaViewEngine with something else for this controller base
            // class.  This is impossible as we create a new MatchViewEngine
            // instance here and it cannot be replace by other view engine

            //var viewEngine = new MatchaViewEngine();
            var viewEngine = CreateViewEngine();
            var html = viewEngine.Render(viewName, context);
            Console.WriteLine(html);
        }

        // solution 1 : provide default implementation by subclass
        // which implement the Controller base class can overwrite this CreateViewEngine()
        // by providing a new viewEngine class
        protected virtual IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }

        // solution 2 : Set it as an abstract class and force the
        // concrete class to provide the implemenation
        //protected abstract IViewEngine CreateViewEngine();

        // by doing solution 1 and 2 - I am defering object creation to subclasses

    }
}

using System;

namespace FactoryMetthodPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Definition - Defer the creation of an object to subclasses (ask the sub classes
            // to create the object themselves by using abstract or provide a default implementation for them
            // so they overwrite it if they want to)

            // we have a provide a default implmentation / or set to to abstract
            // in the method so the concrete class create it own viewengine
            // but we also allow subclass to overwrite an provide a new
            // implementation of it.  Act like a factory to return object
            // we use Controller.cs - CreateViewEngine() method for this exampl
            // and we create a new controller which implement the Controller base class
            // but replace the createViewEngine() methtod to return new SharpViewEngine()
            // we pretent creating a new web frame work for example

            // view Render by Matcha
            //new ProductsController().ListProducts();

            // view Render by Sharp if we change the ProductController to implement SharpController()
            new ProductsController().ListProducts();
        }
    }
}

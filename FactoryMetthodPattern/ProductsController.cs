using System;
using System.Collections.Generic;
using FactoryMetthodPattern.Sharp;

namespace FactoryMetthodPattern
{
    // Change the baseController below to swap the ViewEngine between Matcha and Sharp
    // The SharpController inherit the base class of Controller by overwrite the Render Method
    // in the SharpController

    // Factor Pattern : Defer the creation of an object to subclasses
    // We allow subclass (ProductController) to create a new object (Return SharpViewEngine) as a factory
    // in this case, we allow the the ShapeController to create the ViewEngine (like a factor) by
    // overwrite the CreateViewEngine() method in the base class (Controller.cs) from the concreteClass
    // SharpController.cs with the CreateViewEngine() Method with virtual and override keywords in the methods

    //public class ProductsController : Controller
    public class ProductsController : SharpController
    {
        public void ListProducts()
        {
            // Get products from a database
            Dictionary<string, object> context = new Dictionary<string, object>();
            // context.put(products);
            Render("Product.html", context);
        }
    }
}

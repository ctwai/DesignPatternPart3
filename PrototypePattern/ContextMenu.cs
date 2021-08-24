using System;
namespace PrototypePattern
{
    // Prototype pattern uses to create a new object by copy existing object
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            // Open and close principle
            // extensible to any component type
            // ContentMenu class doesn't need to know all component types

            var newComponent = component.Clone();
            // Add the new component to UI
            // (IComponent/Circle/ContentMenu -> Prototype/ConcretePrototype/Client)
        }
    }
}

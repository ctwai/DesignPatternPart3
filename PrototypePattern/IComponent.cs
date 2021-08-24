using System;
namespace PrototypePattern
{
    public interface IComponent
    {
        void Render();
        IComponent Clone();
    }
}

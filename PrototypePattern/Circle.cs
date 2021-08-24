using System;
namespace PrototypePattern
{
    public class Circle : IComponent
    {
        private float _radius;

        public float Radius
        {
            get { return _radius;  }
            set { _radius = value;  }
        }

        public IComponent Clone()
        {
            var newCircle = new Circle();
            newCircle.Radius = _radius;
            return newCircle;
        }

        public void Render()
        {
            Console.WriteLine("Render Circle");
        }
    }
}

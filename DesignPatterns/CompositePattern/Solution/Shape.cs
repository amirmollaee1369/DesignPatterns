using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern.Solution
{
    public class Shape :IComponent
    {
        private string ShapeName = "";
        public Shape(string _ShapeName)
        {
            ShapeName = _ShapeName;
        }

        public void Render()
        {
            Console.WriteLine($"Render Shape {ShapeName}");
        }

        public void Move()
        {
            Console.WriteLine($"Move Shape {ShapeName}");
        }
    }
}

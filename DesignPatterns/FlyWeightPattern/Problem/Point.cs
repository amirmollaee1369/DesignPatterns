using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeightPattern.Problem
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public PointType type { get; set; }
        public string icon { get; set; }
        public Point(int x, int y, PointType type, string icon)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            this.icon = icon;
        }

        public void draw()
        {
            Console.WriteLine($"{type} {x},{y}");
        }
    }
}

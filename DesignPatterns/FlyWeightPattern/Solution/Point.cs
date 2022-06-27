using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeightPattern.Solution
{
    public class Point
    {
        private int x;
        private int y;
        //to solve the problem cut this and paste into other class
        //private PointType type;
        //to solve the problem cut this and paste into other class
        //private byte[] icon;
        private PointIcon icon;
        public Point(int x, int y, PointIcon icon
            //, PointType type, byte[] icon
            )
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
            //this.type = type;
            //this.icon = icon;
        }

        public void draw()
        {
            Console.WriteLine($"{icon.icon} at ({x},{y})");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeightPattern.Problem
{
    public class PointService
    {
        public List<Point> getPoints()
        {
            List<Point> points = new List<Point>();
            Point point = new Point(1, 2, PointType.HOSPITAL, "hospital");
            points.Add(point);
            return points;
        }
    }
}

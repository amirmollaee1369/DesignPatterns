using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeightPattern
{
    public class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> getPoints()
        {
            var points = new List<Point>();
            //points.Add(new Point(2,5,PointType.CAFE,));
            points.Add(new Point(2, 5, _iconFactory.getPointIcon(PointType.CAFE)));
            return points;
        }
    }
}

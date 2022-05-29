using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeightPattern
{
    public class PointIconFactory
    {
        private Dictionary<PointType,PointIcon> icons = new Dictionary<PointType, PointIcon>();
        public PointIcon getPointIcon(PointType type)
        {
            if (!icons.ContainsKey(type))
                icons.Add(type, new PointIcon(type, null));
            return icons[type];
        }
    }
}

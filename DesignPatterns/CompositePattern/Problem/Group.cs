using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern.Problem
{
    public class Group
    {
        List<object> objects= new List<object>();
        public void add(object obj)
        {
            objects.Add(obj);
        }

        public void render()
        {
            foreach (var obj in objects)
            {
                if(obj.GetType() == typeof(Shape))
                    ((Shape)obj).render();
                else
                    ((Group)obj).render();
            }
        }
    }
}

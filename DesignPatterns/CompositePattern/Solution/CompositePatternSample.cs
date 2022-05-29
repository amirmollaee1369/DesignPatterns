using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern.Solution
{
    public static class CompositePatternSample
    {
        public static void Run()
        {
            var group1 = new Group();
            group1.Add(new Shape("Squar1"));//Squar
            group1.Add(new Shape("Squar2"));//Squar

            var group2 = new Group();
            group2.Add(new Shape("Circle1"));//Circle
            group2.Add(new Shape("Circle2"));//Circle

            var group = new Group();
            group.Add(group1);
            group.Add(group2);
            group.Render();
            group.Move();
        }
    }
}

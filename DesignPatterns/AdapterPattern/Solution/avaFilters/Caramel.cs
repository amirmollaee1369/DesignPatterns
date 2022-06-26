using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Solution.avaFilters
{
    public class Caramel
    {
        public void init() { }
        public void render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter From 3-rd Libraries");
        }
    }
}

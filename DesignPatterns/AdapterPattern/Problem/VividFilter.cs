using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Problem
{
    public class VividFilter : IFilter
    {
        public void apply(Image image)
        {
            Console.WriteLine("applying Vivid Filter");
        }
    }
}

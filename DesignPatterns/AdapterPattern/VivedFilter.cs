using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class VivedFilter : IFilter
    {
        public void apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}

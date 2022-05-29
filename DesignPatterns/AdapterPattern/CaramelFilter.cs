using DesignPatterns.AdapterPattern.avaFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class CaramelFilter : Caramel,IFilter
    {
        
        public CaramelFilter()
        {
        }

        public void apply(Image image)
        {
            init();
            render(image);
        }
    }
}


using DesignPatterns.AdapterPattern.Solution.avaFilters;

namespace DesignPatterns.AdapterPattern.Solution
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

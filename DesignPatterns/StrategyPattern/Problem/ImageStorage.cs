using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Problem
{
    public class ImageStorage
    {
        public string compressor { get; set; }
        public string filter { get; set; }
        public ImageStorage(string compressor, string filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void store(string fileName)
        {
            if (compressor == "jpeg")
                Console.WriteLine("Comperssing using jpeg");
            else if (compressor == "png")
                Console.WriteLine("Comperssing using png");


            if (filter == "b&W")
                Console.WriteLine("Applying b&w filter");
            else if (filter == "high-contrast")
                Console.WriteLine("Applying high-contrast filter");

        }
    }
}

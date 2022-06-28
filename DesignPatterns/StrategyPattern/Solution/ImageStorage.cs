using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Solution
{
    public class ImageStorage
    {
        private ICompressor compressor;
        private IFilter filter;

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void store(string fileName)
        {
            compressor.compress(fileName);

            filter.apply(fileName);
        }
    }
}

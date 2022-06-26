using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Problem
{
    public class ImageView
    {
        private Image image { get; set; }

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void apply(IFilter filter)
        {
            filter.apply(image);
        }
    }
}

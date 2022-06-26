using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Problem
{
    public interface IFilter
    {
        void apply(Image image);
    }
}

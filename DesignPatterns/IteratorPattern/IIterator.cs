using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public interface IIterator<T>
    {
        bool hasNext();
        T current();
        void next();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution.PushStyle
{
    public interface IObserver
    {
        void update(int value);
    }
}

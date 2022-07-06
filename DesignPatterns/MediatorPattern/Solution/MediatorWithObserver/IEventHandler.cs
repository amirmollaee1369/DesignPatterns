using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution.MediatorWithObserver
{
    public interface IEventHandler
    {
        void handle();
    }
}

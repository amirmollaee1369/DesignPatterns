using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution.MediatorWithObserver
{
    public abstract class UIControl
    {
        private List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public void addEventHandler(IEventHandler eventHandler)
        {
            this.eventHandlers.Add(eventHandler);
        }

        protected void notifyEventHandle()
        {
            foreach (IEventHandler eventHandler in eventHandlers)
                eventHandler.handle();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Solution
{
    public abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void handle(HttpRequest httpRequest)
        {
            if (doHandle(httpRequest))
                return;

            if (next != null)
                next.handle(httpRequest);
        }

        public abstract bool doHandle(HttpRequest httpRequest);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplatePattern.Solution
{
    public abstract class Task
    {
        private AuditTrail audit;

        public Task(AuditTrail audit)
        {
            this.audit = audit;
        }

        public void execute()
        {
            audit.record();

            doExecute();
        }

        protected abstract void doExecute();
    }
}

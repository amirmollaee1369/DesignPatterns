using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplatePattern.Solution
{
    public class TransferMoneyTask : Task
    {
        public TransferMoneyTask(AuditTrail audit) : base(audit)
        {
        }

        protected override void doExecute()
        {
            Console.WriteLine("Transfer Mony");
        }
    }
}

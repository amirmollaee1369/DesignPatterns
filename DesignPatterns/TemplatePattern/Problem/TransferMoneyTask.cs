using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplatePattern.Problem
{
    public class TransferMoneyTask
    {
        public AuditTrail auditTrail;

        public TransferMoneyTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void execute() {
            auditTrail.record();

            Console.WriteLine("Transfer Mony");
        }
    }
}

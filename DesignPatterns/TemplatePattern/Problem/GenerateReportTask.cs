using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplatePattern.Problem
{
    public class GenerateReportTask
    {
        public AuditTrail auditTrail;

        public GenerateReportTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void execute() {
            auditTrail.record();

            Console.WriteLine("Generate Report");
        }
    }
}

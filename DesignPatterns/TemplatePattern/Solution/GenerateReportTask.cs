using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplatePattern.Solution
{
    public class GenerateReportTask : Task
    {
        public GenerateReportTask(AuditTrail audit) : base(audit)
        {
        }

        protected override void doExecute()
        {
            Console.WriteLine("Generate Repo");
        }
    }
}

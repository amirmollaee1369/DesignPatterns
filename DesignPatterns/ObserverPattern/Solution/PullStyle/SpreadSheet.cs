using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution.PullStyle
{
    public class SpreadSheet : IObserver
    {
        private DataSource dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void update()
        {
            Console.WriteLine($"SpreadSheat got nitified.{dataSource.getValue()}");
        }
    }
}

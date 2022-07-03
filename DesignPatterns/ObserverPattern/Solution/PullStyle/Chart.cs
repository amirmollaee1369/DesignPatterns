using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution.PullStyle
{
    internal class Chart : IObserver
    {
        private DataSource dataSource;

        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void update()
        {
            Console.WriteLine($"Chart got updated{dataSource.getValue()}");
        }
    }
}

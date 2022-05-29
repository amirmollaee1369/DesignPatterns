using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.fx
{
    public class Button
    {
        private string label;
        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void click()
        {
            command.execute();
        }
    }
}

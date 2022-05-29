using DesignPatterns.CommandPattern.fx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> commands;

        public CompositeCommand()
        {
            this.commands = new List<ICommand>();
        }

        public void add(ICommand command)
        {
            commands.Add(command);
        }

        public void execute()
        {
            foreach (var command in commands)
            {
                command.execute();
            }
        }
    }
}

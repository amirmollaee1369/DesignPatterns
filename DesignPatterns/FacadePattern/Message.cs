using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern
{
    public class Message
    {
        public string content;

        public Message(string content)
        {
            this.content = content;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern.Problem
{
    public class Message
    {
        public string content { get; set; }

        public Message(string content)
        {
            this.content = content;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.editor
{
    public class HtmlDocument
    {
        public string content { get; set; }
        public void makeBold()
        {
            content = $"<b>{content}</b>";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.editor
{
    public class BoldCommand : IUndoableCommand
    {
        private string prevContent { get; set; }
        private HtmlDocument htmlDocument { get; set; }
        private History history { get; set; }
        public BoldCommand(HtmlDocument htmlDocument, History history)
        {
            this.htmlDocument = htmlDocument;
            this.history = history;
        }

        public void execute()
        {
            prevContent = htmlDocument.content;
            htmlDocument.makeBold();
            history.push(this);
        }

        public void unExecute()
        {
            htmlDocument.content = prevContent;
        }
    }
}

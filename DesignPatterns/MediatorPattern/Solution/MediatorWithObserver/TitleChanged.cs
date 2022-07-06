using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution.MediatorWithObserver
{
    public class TitleChanged : IEventHandler
    {
        public TextBox titleTextBox;
        public Button saveButton;

        public TitleChanged(TextBox titleTextBox, Button saveButton)
        {
            this.titleTextBox = titleTextBox;
            this.saveButton = saveButton;
        }

        public void handle()
        {
            var content = titleTextBox.GetContent();
            var isEmpty = (content == null || string.IsNullOrEmpty(content));
            saveButton.SetisEnabled(!isEmpty);
        }
    }
}

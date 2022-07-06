using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution.MediatorWithObserver
{
    public class ArticleSelectedObserver : IEventHandler
    {
        public ListBox articleListBox;
        public TextBox titleTextBox;
        public Button saveButton;

        public ArticleSelectedObserver(ListBox articleListBox, TextBox titleTextBox, Button saveButton)
        {
            this.articleListBox = articleListBox;
            this.titleTextBox = titleTextBox;
            this.saveButton = saveButton;
        }

        public void handle()
        {
            titleTextBox.SetContent(articleListBox.GetSelection());
            saveButton.SetisEnabled(true);
        }

    }
}

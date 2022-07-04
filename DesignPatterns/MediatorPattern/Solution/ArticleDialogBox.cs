using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution
{
    public class ArticleDialogBox : DialogBox
    {
        public ListBox articleListBox;
        public TextBox titleTextBox;
        public Button saveButton;

        public ArticleDialogBox()
        {
            this.articleListBox = new ListBox(this);
            this.titleTextBox = new TextBox(this);
            this.saveButton = new Button(this);
        }

        public void simulateUserInteraction()
        {
            articleListBox.SetSelection("article 1");
            Console.WriteLine($"TextBox:{titleTextBox.GetContent()}");
            Console.WriteLine($"Button:{saveButton.GetisEnabled()}");
        }

        public override void changed(UIControl control)
        {
            if (control == articleListBox)
                articleSelected();
            else if (control == titleTextBox)
                titleChanged();
        }

        public void articleSelected()
        {
            titleTextBox.SetContent(articleListBox.GetSelection());
            saveButton.SetisEnabled(true);
        }

        public void titleChanged()
        {
            var content=titleTextBox.GetContent();
            var isEmpty = (content == null || string.IsNullOrEmpty(content));
            saveButton.SetisEnabled(!isEmpty);
        }
    }
}

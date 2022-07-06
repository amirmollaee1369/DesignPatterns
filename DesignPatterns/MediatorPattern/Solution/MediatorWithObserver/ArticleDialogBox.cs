using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern.Solution.MediatorWithObserver
{
    public class ArticleDialogBox
    {
        public ListBox articleListBox;
        public TextBox titleTextBox;
        public Button saveButton;

        public ArticleDialogBox()
        {
            this.articleListBox = new ListBox();
            this.titleTextBox = new TextBox();
            this.saveButton = new Button();
            articleListBox.addEventHandler(new ArticleSelectedObserver(articleListBox,titleTextBox,saveButton));
            articleListBox.addEventHandler(new TitleChanged(titleTextBox,saveButton));
        }

        public void simulateUserInteraction()
        {
            articleListBox.SetSelection("article 1");
            Console.WriteLine($"TextBox:{titleTextBox.GetContent()}");
            Console.WriteLine($"Button:{saveButton.GetisEnabled()}");
        }
    }

}

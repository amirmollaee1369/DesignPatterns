using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern.Problem
{
    public class Ebook
    {
        private string fileName;

        public Ebook(string fileName)
        {
            this.fileName = fileName;
            load();
        }

        public void load()
        {
            Console.WriteLine("Looding the ebook " + fileName);
        }

        public void show()
        {
            Console.WriteLine("Showing the ebook " + fileName);
        }

        public string getFileName()
        {
            return fileName;
        }
    }
}

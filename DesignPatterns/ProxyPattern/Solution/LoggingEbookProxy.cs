using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ProxyPattern.Solution
{
    public class LoggingEbookProxy : IEbook
    {
        private string fileName;
        private RealEbook ebook;
        public LoggingEbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string getFileName()
        {
            return fileName;
        }

        public void show()
        {
            if(ebook == null)
                ebook=new RealEbook(fileName);

            Console.WriteLine("Logging");
            ebook.show();
        }
    }
}

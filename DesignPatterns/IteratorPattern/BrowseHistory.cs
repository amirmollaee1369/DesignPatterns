using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class BrowseHistory
    {
        private List<string> urls { get; } = new List<string>();
        //private string[] urls { get; } = new string[10];
        //private int count = 0;
        public void push(string url)
        {
            urls.Add(url);

            //urls[count++] = url;
        }

        public string pop()
        {
            var lastIndex = urls.Count - 1;
            var url = urls[lastIndex];
            urls.RemoveAt(lastIndex);
            return url;
            //return urls[--count];
        }

        public IIterator<string> createIterator()
        {
            return new ListIterator(this);
        }

        //public IIterator<string> createIterator()
        //{
        //    return new ArrayIterator(this);
        //}

        public class ListIterator : IIterator<string>
        {
            public BrowseHistory history { get; }
            public int index { get; set; }
            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string current()
            {
                return history.urls[index];
            }

            public bool hasNext()
            {
                return (index < history.urls.Count);
                //return history.urls[index]!=null;
            }

            public void next()
            {
                index++;
            }
        }
        public class ArrayIterator : IIterator<string>
        {
            public BrowseHistory history { get; }
            public int index { get; set; }
            public ArrayIterator(BrowseHistory history)
            {
                this.history = history;
            }

            public string current()
            {
                return history.urls[index];
            }

            public bool hasNext()
            {
                return history.urls[index]!=null;
            }

            public void next()
            {
                index++;
            }
        }
    }
}

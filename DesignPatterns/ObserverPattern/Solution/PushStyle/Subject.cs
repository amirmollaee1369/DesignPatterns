using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Solution.PushStyle
{
    public class Subject
    {
        public List<IObserver> observers = new List<IObserver>();

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers(int value)
        {
            foreach (IObserver observer in observers)
                observer.update(value);
        }
    }
}

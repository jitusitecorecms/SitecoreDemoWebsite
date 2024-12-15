using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Observer
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is ConcreteSubject concreteSubject && concreteSubject.State < 5)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }

    public class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if (subject is ConcreteSubject concreteSubject && concreteSubject.State >= 5)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }

}

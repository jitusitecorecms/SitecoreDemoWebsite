using System;
using System.Collections.Generic;

namespace DesignPatternDemo.Observer
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public int State { get; private set; }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Doing some work and changing state.");
            State = new Random().Next(0, 10);
            Notify();
        }
    }

}

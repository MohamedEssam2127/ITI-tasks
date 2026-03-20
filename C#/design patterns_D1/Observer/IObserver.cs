using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObserver
    {
        void Update();
    }

    public abstract class Ball
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AttachObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}

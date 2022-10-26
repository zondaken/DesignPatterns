using System.Collections.Generic;

namespace Observer_PushUpdate
{
    public abstract class ObservableBase
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        protected void NotifyObservers(string state)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(state);
            }
        }
    }
}
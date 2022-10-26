using System.Collections.Generic;

namespace Observer_Push
{
    public abstract class ObservableBase
    {
        public abstract ObservableState State { get; set; }
        
        private List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer) => _observers.Add(observer);

        public void RemoveObserver(IObserver observer) => _observers.Remove(observer);

        protected void NotifyObservers(ObservableBase observable)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
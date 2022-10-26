using System;

namespace Observer_Push
{
    public class ConsoleLogger : IObserver
    {
        public void Update(ObservableBase observable)
        {
            Console.WriteLine("OBSERVER 1 : {0}", observable.State.Name);
        }
    }
}
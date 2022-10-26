using System;

namespace Observer_PushUpdate
{
    public class ConsoleLogger : IObserver
    {
        public void Update(string state)
        {
            Console.WriteLine(state);
        }
    }
}
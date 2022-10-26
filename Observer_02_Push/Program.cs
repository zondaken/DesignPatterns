using System;

namespace Observer_Push
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var observer = new ConsoleLogger();
            
            var subject = new Subject();
            subject.AddObserver(observer);

            var state = subject.State;
            state.Name = "New Name";

            subject.State = state;
        }
    }
}
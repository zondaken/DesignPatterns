using System;

namespace Observer_PushUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var observer = new ConsoleLogger();
            
            var subject = new Subject();
            subject.AddObserver(observer);

            subject.State = "New State";
        }
    }
}
using System;

namespace Module._10.Interfaces
{
    public interface IWorker
    {
        void Build();
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Билд!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Worker worker = new Worker();

            ((IWorker)worker).Build();
        }
    }
}

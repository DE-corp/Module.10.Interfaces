using System;

namespace Module._10.Interfaces
{
    public interface IWorker
    {
        public void Build();
    }

    public class Worker : IWorker
    {
        public void Build()
        {
            Console.WriteLine("Билд!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Worker worker = new Worker();

            worker.Build();
        }
    }
}

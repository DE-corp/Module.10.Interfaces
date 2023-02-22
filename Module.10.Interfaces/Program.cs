using System;

namespace Module._10.Interfaces
{
    public interface IWriter
    {
        void Write();
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Пишу!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Writer writer = new Writer();

            ((IWriter)writer).Write();
        }
    }
}

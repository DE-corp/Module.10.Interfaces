using System;

namespace Module._10.Interfaces
{
    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    class ElectronicBook : IBook, IDevice
    {
        void IBook.Read()
        {
            throw new NotImplementedException();
        }

        void IDevice.TurnOff()
        {
            Console.WriteLine("Выкл");
        }

        void IDevice.TurnOn()
        {
            Console.WriteLine("Вкл");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            IDevice electronicBook = new ElectronicBook();
            electronicBook.TurnOn();
            electronicBook.TurnOff();
        }
    }
}

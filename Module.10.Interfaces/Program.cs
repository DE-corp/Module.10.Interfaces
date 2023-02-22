using System;

namespace Module._10.Interfaces
{
    public interface IFile
    {
        void ReadFile();
    }

    public interface IBinaryFile
    {
        void ReadFile();
        void OpenBinaryFile();
    }

    public interface IMailer
    {
        void SendMail();
    }

    class FileManager : IFile, IBinaryFile, IMailer
    {
        public void OpenBinaryFile()
        {
            Console.WriteLine("Открываем бинарный файл");
        }

        public void SendMail()
        {
            Console.WriteLine("Отправляем письмо");
        }

        void IFile.ReadFile()
        {
            Console.WriteLine("Читаем текстовый файл");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Читаем бинарный файл");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            IFile file = new FileManager();
            IBinaryFile binaryFile = new FileManager();
            IMailer mailer = new FileManager();

            file.ReadFile();
            binaryFile.ReadFile();
            binaryFile.OpenBinaryFile();
            mailer.SendMail();
        }
    }
}

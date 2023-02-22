using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module._10.Interfaces
{
    public class Worker1:IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker 1 работает");
            Thread.Sleep(3000);
            Logger.Event("Worker 1 окончил работу");
        }
    }

    public class Worker2 : IWorker
    {
        ILogger Logger { get; }
        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker 2 работает");
            Thread.Sleep(3000);
            Logger.Event("Worker 2 окончил работу");
        }
    }

    public class Worker3 : IWorker
    {
        ILogger Logger { get; }
        public Worker3(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker 3 работает");
            Thread.Sleep(3000);
            Logger.Event("Worker 3 окончил работу");
        }
    }
}

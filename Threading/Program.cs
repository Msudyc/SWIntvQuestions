// Thread PV
namespace Threading
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region SyncPrint test
            // SyncPrint test
            Console.WriteLine("Start SyncPrint test...");
            SyncPrint t = new SyncPrint();
            Thread syncPrint1 = new Thread(t.Foo);
            Thread syncPrint2 = new Thread(t.Bar);
            syncPrint1.Start();
            syncPrint2.Start();
            syncPrint1.Join();
            syncPrint2.Join();
            Console.WriteLine("SyncPrint test is done.");
            #endregion

            Console.ReadLine();
        }
    }
}

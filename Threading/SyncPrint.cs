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

    /// <summary>
    /// Print FooBar in order.
    /// One thread prints "Foo", another thread prints "Bar". 
    /// Print 10 times of "FooBar".
    /// </summary>
    public class SyncPrint
    {
        private const int MaxRun = 10;
        private const int SleepTime = 200;

        private Semaphore foo = new Semaphore(1, 1);
        private Semaphore bar = new Semaphore(0, 1);

        internal void Foo()
        {
            int count = 0;
            while (count < MaxRun)
            {
                this.foo.WaitOne();
                Console.Write("Foo");
                this.bar.Release();
                Thread.Sleep(TimeSpan.FromMilliseconds(SleepTime));
                count++;
            }
        }

        internal void Bar()
        {
            int count = 0;
            while (count < MaxRun)
            {
                this.bar.WaitOne();
                Console.Write("Bar\n");
                this.foo.Release();
                Thread.Sleep(TimeSpan.FromMilliseconds(SleepTime));
                count++;
            }
        }
    }
}

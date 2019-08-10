using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace TryFuncAction
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Hello Cruel World!!!");
            Program pg = new Program();
            pg.TrySomething();
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// </summary>
        public void TrySomething()
        {
            DemoProcess demoProcess = new DemoProcess();
            // TODO: Create a second class and pass a method from that class to demoProcess

            bool retValue = false;
            for(int multip = 0; multip < 5; multip++)
            {
                retValue = demoProcess.DoSomething(SomeProcessingMethodA, multip);
                Console.WriteLine(@"Status after call: {0}", retValue);
            }

            Console.WriteLine(@"*** Funcs in another class ***");
            DemoSubProcessA subProcessA = new DemoSubProcessA();

            for (int multip1 = 10; multip1 < 15; multip1++)
            {
                retValue = demoProcess.DoSomething(subProcessA.SomeProcessingMethodA, multip1);
                Console.WriteLine(@"Status after call: {0}", retValue);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg1"></param>
        /// <param name="seqNo"></param>
        /// <returns></returns>
        private bool SomeProcessingMethodA(string msg1, int seqNo)
        {
            bool retValue = false;
            
            string curName = this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name;
            int updatedSeq = SomeSupportMethodForA(seqNo);
            Console.WriteLine(@"[{0}] Message from caller: {1}, seqno: {2}", curName, msg1, updatedSeq);
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seqNo"></param>
        /// <returns></returns>
        private int SomeSupportMethodForA(int seqNo)
        {
            return (seqNo * 2);
        }

    }
}

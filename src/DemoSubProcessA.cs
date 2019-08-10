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
    public class DemoSubProcessA
    {
        /// <summary>
        /// 
        /// </summary>
        public DemoSubProcessA()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg1"></param>
        /// <param name="seqNo"></param>
        /// <returns></returns>
        public bool SomeProcessingMethodA(string msg1, int seqNo)
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

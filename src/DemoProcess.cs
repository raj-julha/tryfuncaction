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
    public class DemoProcess
    {
        /// <summary>
        /// 
        /// </summary>
        public DemoProcess()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processingMethod"></param>
        /// <returns></returns>
        public bool DoSomething(Func<string, int, bool> processingMethod, int multiplier)
        {
            bool retValue = true;

            string msg = this.GetType().Name + "." + MethodBase.GetCurrentMethod().Name;
            processingMethod(string.Format(@"Something happens insde [{0}] class", msg ), (multiplier+10));

            return retValue;
        }

    }
}

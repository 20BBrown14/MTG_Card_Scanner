using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_Scanner
{
    /// <summary>
    /// Class to handle code contracts to verify parameters.
    /// 
    /// Author: Branden Brown
    /// </summary>
    public class CodeContract
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Code contract to help validate method args. If predicate is true the contract has 
        /// been broken and Message is passed to Debug and then throws TException. 
        /// Otherwise does nothing.
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <param name="Predicate">bool: The test</param>
        /// <param name="Message">string: The debug message</param>
        public static void Requires<TException>(bool Predicate, string Message)
            where TException : Exception, new()
        {
            if (Predicate)
            {
                _log.Error(Message);
                throw new TException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTG_Card_Scanner
{
    class CodeContract
    {
        public static void Requires<TException>(bool Predicate, string Message)
            where TException : Exception, new()
        {
            if (!Predicate)
            {
                Debug.WriteLine(Message);
                throw new TException();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MTG_Card_Scanner.CodeContract;

namespace MTG_Card_Scanner
{
    /// <summary>
    /// Model for an MTG card set
    /// 
    /// Author: Branden Brown
    /// </summary>
    public class MTGSet
    {
        public string setName { get; }

        public string setCode { get; }

        /// <summary>
        /// Constructor for the class MTGSet.
        /// </summary>
        /// <param name="setName">string: The name of the set. Cannot be <code>null</code> or empty.</param>
        /// <param name="setCode">string: The code of the set. Cannot be <code>null</code> or empty.</param>
        public MTGSet(string setName, string setCode)
        {
            Requires<ArgumentNullException>(String.IsNullOrEmpty(setName), "Set name cannot be null or empty");
            Requires<ArgumentNullException>(String.IsNullOrEmpty(setCode), "Set code cannot be null or empty");
            this.setName = setName;
            this.setCode = setCode;
        }
    }
}

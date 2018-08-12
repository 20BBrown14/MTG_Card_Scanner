using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MTG_Card_Scanner.CodeContract;

namespace MTG_Card_Scanner
{
    /// <summary>
    /// Card model to hold information regarding an MTG card.
    /// 
    /// Author: Branden Brown
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The name of card
        /// </summary>
        public String Name { get; private set; }

        /// <summary>
        /// The set the card belongs to
        /// </summary>
        public String Set { get; private set; }

        /// <summary>
        /// The card number of this card
        /// </summary>
        public String CardNumber { get; private set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">The name of this card. Cannot be <code>null</code> or empty.</param>
        /// <param name="set">The set this card belongs to. Cannot be <code>null</code> or empty.</param>
        /// <param name="cardNumber">The card number of this card.</param>
        public Card (string name, string set, string cardNumber)
        {
            Requires<ArgumentNullException>(String.IsNullOrEmpty(name), "name cannot be null or empty");
            Requires<ArgumentNullException>(String.IsNullOrEmpty(set), "set cannot be null or empty");
            this.Name = name;
            this.Set = set;
            this.CardNumber = cardNumber;
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="Card.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace GoFish
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Class used to represent a card
    /// </summary>
   [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not taught.")]
    public class Card
    {
        /// <summary>
        /// The card's name
        /// </summary>
        public string Name;

        /// <summary>
        /// The card's suit
        /// </summary>
        public int Suit;

        /// <summary>
        /// The card's value
        /// </summary>
        public int Value;

        /// <summary>
        /// The card's Key
        /// </summary>
        public int Key;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class 
        /// </summary>
        public Card()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class 
        /// Constructor that is used by deck to create a list(deck) of cards.
        /// </summary>
        /// <param name="name"> The card's name</param>
        /// <param name="suit"> The card's suit</param>
        /// <param name="value"> The card's value</param>
        /// <param name="key"> The card's key</param>
        public Card(string name, int suit, int value, int key)
       {
           this.Name = name;
           this.Suit = suit;
           this.Value = value;
           this.Key = key;
       }
    }
}

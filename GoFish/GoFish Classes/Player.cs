//-----------------------------------------------------------------------
// <copyright file="Player.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace GoFish
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Windows.Markup;

    /// <summary>
    /// Players class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not taught.")]
    public class Player
    {
        /// <summary>
        /// string to hold player's name
        /// </summary>
        public string Name;

        /// <summary>
        /// List to hold cards
        /// </summary>
        public List<Card> Hand;

        /// <summary>
        /// Random for computer generated card selection
        /// </summary>
        public Random Rand = new Random();

        /// <summary>
        /// keeps track of the books count
        /// </summary>
        public List<string> Books;

        /// <summary>
        /// bool for if ai or not
        /// </summary>
        private bool ai;

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class
        /// Blank constructor for Players
        /// </summary>
        public Player()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class 
        /// Constructor to determine player's turn and hand.
        /// </summary>
        /// <param name="cards">hand of cards</param>
        public Player(List<Card> cards)
        {
            this.Hand = cards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Player"/> class 
        /// overloaded Constructor sets the (computer players) turn, card list and random
        /// </summary>
        /// <param name="cards">set list of cards to player hand</param>
        /// <param name="rand">random value for </param>
        public Player(List<Card> cards, Random rand)
        {           
            this.Hand = cards; // set the cards
            this.Rand = rand; // set the random value
        }

        /// <summary>
        /// Gets or sets a value indicating whether it's AI
        /// </summary>
        public bool Ai
        {
            get { return this.ai; }
            set { this.ai = value; }
        }
    }
}

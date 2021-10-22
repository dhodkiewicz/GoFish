//-----------------------------------------------------------------------
// <copyright file="Deck.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace GoFish
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Linq;
    using System.Resources;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    
    /// <summary>
    /// Deck class
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not taught.")]
    public class Deck
    {
        /// <summary>
        /// Create List using card class named CardsDeck.
        /// </summary>
        public List<Card> CardsDeck;

        /// <summary>
        /// list of Players for the game
        /// </summary>
        public List<Player> Players;

        /// <summary>
        /// Initializes a new instance of the <see cref="Deck"/> class 
        /// Adds cards using Card class' constructor to CardsDeck.
        /// </summary>
        public Deck()
        {
            this.CardsDeck = new List<Card>();
            this.CardsDeck.Add(new Card("Ace", 0, 0, 0)); // Start of clubs
            this.CardsDeck.Add(new Card("Two", 0, 1, 1));
            this.CardsDeck.Add(new Card("Three", 0, 2, 2));
            this.CardsDeck.Add(new Card("Four", 0, 3, 3));
            this.CardsDeck.Add(new Card("Five", 0, 4, 4));
            this.CardsDeck.Add(new Card("Six", 0, 5, 5));
            this.CardsDeck.Add(new Card("Seven", 0, 6, 6));
            this.CardsDeck.Add(new Card("Eight", 0, 7, 7));
            this.CardsDeck.Add(new Card("Nine", 0, 8, 8));
            this.CardsDeck.Add(new Card("Ten", 0, 9, 9));
            this.CardsDeck.Add(new Card("Jack", 0, 10, 10));
            this.CardsDeck.Add(new Card("Queen", 0, 11, 11));
            this.CardsDeck.Add(new Card("King", 0, 12, 12)); // End of clubs
            this.CardsDeck.Add(new Card("Ace", 1, 13, 0)); // Start of spades
            this.CardsDeck.Add(new Card("Two", 1, 14, 1));
            this.CardsDeck.Add(new Card("Three", 1, 15, 2));
            this.CardsDeck.Add(new Card("Four", 1, 16, 3));
            this.CardsDeck.Add(new Card("Five", 1, 17, 4));
            this.CardsDeck.Add(new Card("Six", 1, 18, 5));
            this.CardsDeck.Add(new Card("Seven", 1, 19, 6));
            this.CardsDeck.Add(new Card("Eight", 1, 20, 7));
            this.CardsDeck.Add(new Card("Nine", 1, 21, 8));
            this.CardsDeck.Add(new Card("Ten", 1, 22, 9));
            this.CardsDeck.Add(new Card("Jack", 1, 23, 10));
            this.CardsDeck.Add(new Card("Queen", 1, 24, 11));
            this.CardsDeck.Add(new Card("King", 1, 25, 12)); // End of spades
            this.CardsDeck.Add(new Card("Ace", 2, 26, 0)); // Start of hearts
            this.CardsDeck.Add(new Card("Two", 2, 27, 1));
            this.CardsDeck.Add(new Card("Three", 2, 28, 2));
            this.CardsDeck.Add(new Card("Four", 2, 29, 3));
            this.CardsDeck.Add(new Card("Five", 2, 30, 4));
            this.CardsDeck.Add(new Card("Six", 2, 31, 5));
            this.CardsDeck.Add(new Card("Seven", 2, 32, 6));
            this.CardsDeck.Add(new Card("Eight", 2, 33, 7));
            this.CardsDeck.Add(new Card("Nine", 2, 34, 8));
            this.CardsDeck.Add(new Card("Ten", 2, 35, 9));
            this.CardsDeck.Add(new Card("Jack", 2, 36, 10));
            this.CardsDeck.Add(new Card("Queen", 2, 37, 11));
            this.CardsDeck.Add(new Card("King", 2, 38, 12)); // End of hearts
            this.CardsDeck.Add(new Card("Ace", 3, 39, 0)); // Start of diamonds
            this.CardsDeck.Add(new Card("Two", 3, 40, 1));
            this.CardsDeck.Add(new Card("Three", 3, 41, 2));
            this.CardsDeck.Add(new Card("Four", 3, 42, 3));
            this.CardsDeck.Add(new Card("Five", 3, 43, 4));
            this.CardsDeck.Add(new Card("Six", 3, 44, 5));
            this.CardsDeck.Add(new Card("Seven", 3, 45, 6));
            this.CardsDeck.Add(new Card("Eight", 3, 46, 7));
            this.CardsDeck.Add(new Card("Nine", 3, 47, 8));
            this.CardsDeck.Add(new Card("Ten", 3, 48, 9));
            this.CardsDeck.Add(new Card("Jack", 3, 49, 10));
            this.CardsDeck.Add(new Card("Queen", 3, 50, 11));
            this.CardsDeck.Add(new Card("King", 3, 51, 12)); // End of diamonds
        }

        /// <summary>
        /// Method to shuffle the CardsDeck deck.
        /// </summary>
        public void Shuffle()
        {
            Random random = new Random();
            List<Card> newDeck = new List<Card>();
            while (this.CardsDeck.Count > 0)
            {
                int cardToMove = random.Next(this.CardsDeck.Count);
                newDeck.Add(this.CardsDeck[cardToMove]);
                this.CardsDeck.RemoveAt(cardToMove);
            }

            this.CardsDeck = newDeck;
        }

        /// <summary>
        /// Deal method
        /// </summary>
        /// <param name="players"> List of players to deal with</param>
        public void DealPlayers(List<Player> players)
        {
            Card temp;
            List<Player> tempPlayers = new List<Player>();
            foreach (Player p in players)
            {
                p.Hand = new List<Card>();
                int x = 0; // reset the value
                // While hand(x) is less than 7, continue to get card from deck, removing it from the deck and adding to hand
                while (x < 7)
                {
                    temp = this.CardsDeck[x];
                    p.Hand.Add(temp);
                    this.CardsDeck.RemoveAt(x);
                    x++;
                }

                tempPlayers.Add(p); // add updated player to our game list
            }

            this.Players = tempPlayers;
        }

        /// <summary>
        /// Deal method
        /// </summary>
        /// <returns>The top card of the deck</returns>
        public Card ReturnTopCard()
        {
            return this.CardsDeck[0];
        }

        /// <summary>
        /// method to set the turn name and deck
        /// </summary>
        /// <param name="players">list of players</param>
        public void SetTurnNameDeck(List<Player> players)
        {
            int i = 1;
            foreach (Player p in players)
            {
                if (i == 1)
                {
                    p.Name = "Players " + i;
                    p.Hand = new List<Card>();
                    i++;
                }
                else
                {
                    p.Name = "Players " + i;
                    p.Hand = new List<Card>();
                    i++;
                }

                this.DealPlayers(players);
            }
        }

        /// <summary>
        /// determines of a player has a book in hand
        /// </summary>
        /// <param name="player">object of player</param>
        /// <returns>true or false</returns>
        public bool BookFound(Player player)
        {
            Deck d = new Deck();
            int counter = 0;
            d.CardsDeck = new List<Card>();
            List<int> intList = new List<int>();

            foreach (Card c in d.CardsDeck)
            {
                intList.Add(c.Key);
            }

            foreach (Card c in player.Hand)
            {
                if (intList.Contains(c.Key))
                {
                    counter++;
                }
            }

            if (counter == 4)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// gets card name
        /// </summary>
        /// <param name="n"> takes key of card to determine name</param>
        /// <returns>card name</returns>
        public string GetCardName(int n)
        {
            string getCardName = string.Empty;

            if (n == 0)
            {
                getCardName = "Ace";
            }

            if (n == 1)
            {
                getCardName = "Two";
            }

            if (n == 2)
            {
                getCardName = "Three";
            }

            if (n == 3)
            {
                getCardName = "Four";
            }

            if (n == 4)
            {
                getCardName = "Five";
            }

            if (n == 5)
            {
                getCardName = "Six";
            }

            if (n == 6)
            {
                getCardName = "Seven";
            }

            if (n == 7)
            {
                getCardName = "Eight";
            }

            if (n == 8)
            {
                getCardName = "Nine";
            }

            if (n == 9)
            {
                getCardName = "Ten";
            }

            if (n == 10)
            {
                getCardName = "Jack";
            }

            if (n == 11)
            {
                getCardName = "Queen";
            }

            if (n == 12)
            {
                getCardName = "King";
            }

            return getCardName;
        }
    }
}

//-----------------------------------------------------------------------
// <copyright file="Game.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace GoFish
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Class used to represent a dealer
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules",
        "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not taught.")]
    public class Game
    {
        /// <summary>
        /// Deck created from Deck class named Pool
        /// </summary>
        private Deck pool;

        /// <summary>
        /// get the current list of players
        /// </summary>
        private List<Player> player;

        /// <summary>
        /// variable to hold the current turn
        /// </summary>
        private int turn;


        /// <summary>
        /// Gets or sets the current turn
        /// </summary>
        public int Turn
        {
            get { return turn; }
            set { turn = value; }
        }

        /// <summary>
        /// Gets or sets the list of players
        /// </summary>
        public List<Player>Players
        {
            get { return player; }
            set { player = value; }
        }

        /// <summary>
        /// Gets or sets the current Pool
        /// </summary>
        public Deck Pool
        {
            get { return pool; }
            set { pool = value; }
        }

        public FlowLayoutPanel CardPanel;

        // TAKE THE NUMBER OF PLAYERS
      public Game(int numberPlayers, FlowLayoutPanel flp)
      {
            Turn = 0;
            Pool = new Deck(); // instantiate the deck
            Players = new List<Player>();

            for (int x = 0; x < numberPlayers; x++)
            {
                Player p = new Player(); // create a new player per amount of players
                Players.Add(p); // add the player to our list
            }

            int count = 0; // initial counter
            foreach (Player player in Players)
            {

                if (count == 0)
                {
                    player.Name = "Player One"; // name player 1
                    player.Books = new List<string>();
                }
                if (count == 1)
                {
                    player.Name = "Player Two";
                    player.Books = new List<string>();
                }

                if (count == 2)
                {
                    player.Name = "Player Three";
                    player.Books = new List<string>();
                }
                if (count == 3)
                {
                    player.Name = "Player Four";
                    player.Books = new List<string>();
                }
                count++;
            }
            
            Pool.Shuffle(); // shuffle the deck
            Pool.DealPlayers(Players); // deal the players
            CardPanel = flp; // set the Cardpanel to our form one panel

        }

        /// <summary>
        /// Constructor for computer players
        /// </summary>
        /// <param name="numberPlayers"></param>
        /// <param name="flp"></param>
        /// <param name="comps"></param>
        public Game(int numberPlayers, FlowLayoutPanel flp, int comps)
        {
            Turn = 0;
            Pool = new Deck(); // instantiate the deck
            Players = new List<Player>();

            for (int x = 0; x < numberPlayers; x++)
            {
                Player p = new Player(); // create a new player per amount of players
                Players.Add(p); // add the player to our list
            }

            int d = 0;
            for (int x = comps; x > 0; x--)
            {
                Players[numberPlayers - 1 - d].Ai = true;
                d++;
            }

            int count = 0; // initial counter
            foreach (Player player in Players)
            {

                if (count == 0)
                {
                    player.Name = "Player One"; // name player 1
                    player.Books = new List<string>();
                }
                if (count == 1)
                {
                    player.Name = "Player Two";
                    player.Books = new List<string>();
                }

                if (count == 2)
                {
                    player.Name = "Player Three";
                    player.Books = new List<string>();
                }
                if (count == 3)
                {
                    player.Name = "Player Four";
                    player.Books = new List<string>();
                }
                count++;
            }

            Pool.Shuffle(); // shuffle the deck
            Pool.DealPlayers(Players); // deal the players
            CardPanel = flp; // set the Cardpanel to our form one panel
        }
    }
}
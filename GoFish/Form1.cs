//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace GoFish
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Contains interaction logic for Form1
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules",
        "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not taught.")]
    public partial class PbDraw : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PbDraw"/> class
        /// </summary>
        public PbDraw()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// string builder obj for game summary
        /// </summary>
        private StringBuilder strbldr;

        /// <summary>
        /// Timer to simulate AI moves
        /// </summary>
        private Stopwatch timer;

        /// <summary>
        /// holds boolean for endgame
        /// </summary>
        private bool over;

        /// <summary>
        /// Game object created from Dealer class.
        /// </summary>
        public Game Game;

        /// <summary>
        /// Gets or sets stringbuilder obj for game summary
        /// </summary>
        public StringBuilder Strbldr
        {
            get { return strbldr; }
            set { strbldr = value; }
        }

        /// <summary>
        /// Gets or sets whether the game is over
        /// </summary>
        public bool Over
        {
            get { return over; }
            set { over = value; }
        }


        /// <summary>
        /// Creates the the game visuals and initializes the deck and shuffles it.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        /// 

        private void PlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(2, flp);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
        }

        // 3 PLAYER GAME INITIALIZATION
        private void PlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(3, flp);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
        }

        //4 player game init

        private void playerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(4, flp);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
        }

        /// <summary>
        /// Closes the application on click.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this will close the application
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://www.bicyclecards.com/how-to-play/go-fish/");
        }


        // ONE COMPUTER PLAYER
        private void computerPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Dalton Hodkiewcz \n" + "and Travis Lambert " +
                            "©2018", "Informational Message");
        }


        // ask for card method

        private void AskCard_Click(object sender, EventArgs e)
        {
            bool flag = false;
            flpCards.Controls.Clear(); // remove all controls from the panel
            PictureBox clickedPictureBox = sender as PictureBox;
            string c = clickedPictureBox.Tag.ToString();
            Strbldr.Append(Game.Players[Game.Turn].Name + " Asks for a " + c + ";");

            //Call the askcard method, passing the game list players and the cardvalue via picturebox.Tag
            List<Card> tempCards = new List<Card>();

            foreach (Player p in Game.Players)
            {
                if (IsGameOver())
                {
                    return;
                }
                if (p != Game.Players[Game.Turn])
                {
                    foreach (var card in p.Hand)
                    {
                        if (card.Name == c)
                        {
                            flag = true;
                            Game.Players[Game.Turn].Hand.Add(card);
                            tempCards.Add(card);
                            Strbldr.AppendLine(Game.Players[Game.Turn].Name + " Gets a " + c + " from " + p.Name + ";");
                        }
                    }
                    p.Hand = p.Hand.Except(tempCards).ToList();
                    IsThereFourOfKind(Game.Players[Game.Turn]);
                    IsPlayerOutOfCards(Game.Players[Game.Turn]);
                }
            }

            if (!flag)
            {
                Strbldr.AppendLine("Go Fish! " + Game.Players[Game.Turn].Name + " Draws a card...;");
                Card tempCard = new Card();
                tempCard = Game.Pool.ReturnTopCard();
                Game.Players[Game.Turn].Hand.Add(tempCard);
                Game.Pool.CardsDeck.Remove(tempCard);
                IsThereFourOfKind(Game.Players[Game.Turn]);
                Game.Turn++;
                IsTurnOverLimit();
                IsPlayerOutOfCards(Game.Players[Game.Turn]);
                if (IsGameOver())
                {
                    EndGame();
                }
                IfComputerTurn();
            }

            if (Over)
            {
                return;
            }
            UpdateLog(strbldr);
            DisplayTurn(Game.Players[Game.Turn]);
            IfComputerTurn();
        }

        private void DisplayTurn(Player p)
        {
            lblTurns.Text = p.Name + "'s Turn";
           List<Card>cards = p.Hand.OrderBy(o => o.Name).ToList();
           p.Hand = cards;
            timer = new Stopwatch();

            foreach (Card c in p.Hand)
            {
                        var picture = new PictureBox
                        {
                            Size = new Size(80, 130),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = potCardImgLst.Images[c.Value],
                            Tag = c.Name.ToString(),
                        };
                        picture.Click += new EventHandler(AskCard_Click); // method to ask
                        flpCards.Controls.Add(picture);
            }

            if (Game.Players[Game.Turn].Ai)
            {
                timer.Start();
                flpCards.Invalidate();
                flpCards.Update();
                flpCards.Refresh();
                while (timer.Elapsed.Seconds < .9)
                {
                    Application.DoEvents();
                }

                timer.Stop();
            }

            RepositionCards();
        }
        private void IsTurnOverLimit()
        {
            if (Game.Turn >= Game.Players.Count)
            {
                Game.Turn = 0;
            }
        }

        private void UpdateLog(StringBuilder sb)
        {
            if (IsGameOver())
            {
                return;
            }
            tbLog.Text = "";
            string summary = sb.ToString();
            string[] lines = summary.Split(';');
            Array.Reverse(lines);

            foreach (string line in lines)
            {
                tbLog.Text += line + System.Environment.NewLine;
            }

            if (Game.Players[Game.Turn].Ai)
            {
                timer = new Stopwatch();
                timer.Start();
                tbLog.Invalidate();
                tbLog.Update();
                tbLog.Refresh();
                while (timer.Elapsed.Seconds < .75)
                {
                    Application.DoEvents();
                }
                timer.Stop();
            }
        }

        private void IsThereFourOfKind(Player p)
        {
            List<string>names = new List<string>();
            List<Card>temp = new List<Card>();
            foreach (var card in p.Hand)
            {
                names.Add(card.Name);
            }

            string name = "";
            foreach (string str in names)
            {
                int count = 0;
                for (int i = 0; i < p.Hand.Count; i++)
                {
                    if (str == p.Hand[i].Name)
                    {
                        count++;
                        if (count == 4)
                        {
                            name = p.Hand[i].Name;
                        }
                    }
                }
            }

            if (name != "")
            {
                foreach (Card c in p.Hand)
                {
                    if (c.Name == name)
                    {
                        temp.Add(c);
                    }
                }
                p.Books.Add(name);
                tbBooks.Text += p.Name + " has a book of " + name + "'s" + "\n";
                tbBooks.Text += Environment.NewLine;
                p.Hand = p.Hand.Except(temp).ToList();
            }
        }

        private bool IsGameOver()
        {
            if (Game.Pool.CardsDeck.Count == 0)
            {
                int size1 = 0, size2 = 0, size3 = 0, size4 = 0;

                if (Game.Players.Count >= 2)
                {
                    size1 = Game.Players[0].Books.Count;
                    size2 = Game.Players[1].Books.Count;
                    if (Game.Players.Count >= 3)
                    {
                        size3 = Game.Players[2].Books.Count;
                        if (Game.Players.Count >= 4)
                        {
                            size4 = Game.Players[3].Books.Count;
                        }
                    }
                }

                if (size1 > size2 && size1 > size3 && size1 > size4)
                {
                    MessageBox.Show("The winner is " + Game.Players[0].Name + " with " + size1 + " books!");
                    return true;
                }

                if (size2 > size1 && size2 > size3 && size2 > size4)
                {
                    MessageBox.Show("The winner is " + Game.Players[1].Name + " with " + size2 + " books!");
                    return true;
                }

                if (size3 > size1 && size3 > size2 && size3 > size4)
                {
                    MessageBox.Show("The winner is " + Game.Players[2].Name + " with " + size3 + " books!");
                    return true;
                }

                if (size4 > size1 && size4 > size2 && size4 > size3)
                {
                    MessageBox.Show("The winner is " + Game.Players[3].Name + " with " + size4 + " books!");
                    return true;
                }
            }

            return false;
        }

        private void RepositionCards()
        {
            Point temp = new Point();
            foreach (Control c in flpCards.Controls)
            {
                temp = c.Location;
                temp.X = Left - 50;
            }
        }

        private void IsPlayerOutOfCards(Player p)
        {
            Card tempCard = new Card();
            if (p.Hand.Count == 0)
            {
                while (Game.Pool.CardsDeck.Count > 0 && p.Hand.Count < 7)
                {
                    tempCard = Game.Pool.ReturnTopCard();
                    p.Hand.Add(tempCard);
                    this.Game.Pool.CardsDeck.Remove(tempCard);
                }
            }

            if (Game.Pool.CardsDeck.Count == 0)
            {
                if (IsGameOver())
                {
                    EndGame();
                }
            }
        }

        private void EndGame()
        {
            this.lblTurns.Text = "";
            this.tbLog.Text = "";
            this.tbBooks.Text = "";
            flpCards.Controls.Clear();
            this.Focus();
            Over = true;
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndGame();
        }

        // 2 player 1 computer
        private void vS1AIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(2, flp, 1);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }
        
        // 2 player 2 computer
        private void computersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(2, flp, 2);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        /// <summary>
        ///  3 player 1 computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(3, flp, 1);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        /// <summary>
        ///  3 player 2 computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(3, flp, 2);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        /// <summary>
        ///  3 player 3 computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(3, flp, 3);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        /// <summary>
        ///  4 player 1 computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(4, flp, 1);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        /// <summary>
        ///  4 player 2 computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(4, flp, 2);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        /// <summary>
        ///  4 player 3 computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(4, flp, 3);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        /// <summary>
        ///  4 player 4 computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void computerToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = this.flpCards;
            Game game = new Game(4, flp, 4);
            this.Game = game;
            DisplayTurn(Game.Players[Game.Turn]);
            strbldr = new StringBuilder();
            Strbldr = strbldr;
            Over = false;
            IfComputerTurn();
            timer = new Stopwatch();
        }

        private void IfComputerTurn()
        {
            if (this.Game.Players[Game.Turn].Ai == true)
            {
                CompAskForCard();
            }
        }

        private void CompAskForCard()
        {
            bool flag = false;
            flpCards.Controls.Clear(); // remove all controls from the panel
            int max = Game.Players[Game.Turn].Hand.Count;
            int rand = Game.Players[Game.Turn].Rand.Next(0, max);
            string c = Game.Players[Game.Turn].Hand[rand].Name;
            Strbldr.Append(Game.Players[Game.Turn].Name + " Asks for a " + c + ";");

            //Call the askcard method, passing the game list players and the cardvalue via picturebox.Tag
            List<Card> tempCards = new List<Card>();

            foreach (Player p in Game.Players)
            {
                if (IsGameOver())
                {
                    return;
                }

                if (p != Game.Players[Game.Turn])
                {
                    foreach (var card in p.Hand)
                    {
                        if (card.Name == c)
                        {
                            flag = true;
                            Game.Players[Game.Turn].Hand.Add(card);
                            tempCards.Add(card);
                            Strbldr.AppendLine(Game.Players[Game.Turn].Name + " Gets a " + c + " from " + p.Name + ";");
                        }
                    }

                    p.Hand = p.Hand.Except(tempCards).ToList();
                    IsThereFourOfKind(Game.Players[Game.Turn]);
                    IsPlayerOutOfCards(Game.Players[Game.Turn]);
                }
            }

            if (!flag)
            {
                Strbldr.AppendLine("Go Fish! " + Game.Players[Game.Turn].Name + " Draws a card...;");
                Card tempCard = new Card();
                tempCard = Game.Pool.ReturnTopCard();
                Game.Players[Game.Turn].Hand.Add(tempCard);
                Game.Pool.CardsDeck.Remove(tempCard);
                IsThereFourOfKind(Game.Players[Game.Turn]);
                Game.Turn++;
                IsTurnOverLimit();
                IsPlayerOutOfCards(Game.Players[Game.Turn]);
                if (IsGameOver())
                {
                    EndGame();
                }
            }

            if (Over)
            {
                return;
            }

            UpdateLog(strbldr);
            DisplayTurn(Game.Players[Game.Turn]);
            IfComputerTurn();
        }
    }
}

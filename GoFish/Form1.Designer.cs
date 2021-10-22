//-----------------------------------------------------------------------
// <copyright file="Form1.Designer.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace GoFish
{
    partial class PbDraw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PbDraw));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potCardImgLst = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.tb_UserPlayer = new System.Windows.Forms.TextBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.flpCards = new System.Windows.Forms.FlowLayoutPanel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.tbBooks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.vS1AIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem1,
            this.ResetToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // NewGameToolStripMenuItem1
            // 
            this.NewGameToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayerToolStripMenuItem,
            this.PlayerToolStripMenuItem1,
            this.playerToolStripMenuItem2});
            this.NewGameToolStripMenuItem1.Name = "NewGameToolStripMenuItem1";
            this.NewGameToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.NewGameToolStripMenuItem1.Text = "New Game";
            // 
            // PlayerToolStripMenuItem
            // 
            this.PlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vS1AIToolStripMenuItem,
            this.computersToolStripMenuItem});
            this.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem";
            this.PlayerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PlayerToolStripMenuItem.Text = "2 Players";
            this.PlayerToolStripMenuItem.Click += new System.EventHandler(this.PlayerToolStripMenuItem_Click);
            // 
            // PlayerToolStripMenuItem1
            // 
            this.PlayerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerToolStripMenuItem,
            this.computerToolStripMenuItem1,
            this.computerToolStripMenuItem2});
            this.PlayerToolStripMenuItem1.Name = "PlayerToolStripMenuItem1";
            this.PlayerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.PlayerToolStripMenuItem1.Text = "3 Players";
            this.PlayerToolStripMenuItem1.Click += new System.EventHandler(this.PlayerToolStripMenuItem1_Click);
            // 
            // playerToolStripMenuItem2
            // 
            this.playerToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computerToolStripMenuItem3,
            this.computerToolStripMenuItem4,
            this.computerToolStripMenuItem5,
            this.computerToolStripMenuItem6});
            this.playerToolStripMenuItem2.Name = "playerToolStripMenuItem2";
            this.playerToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.playerToolStripMenuItem2.Text = "4 Players";
            this.playerToolStripMenuItem2.Click += new System.EventHandler(this.playerToolStripMenuItem2_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ResetToolStripMenuItem.Text = "Reset";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // potCardImgLst
            // 
            this.potCardImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("potCardImgLst.ImageStream")));
            this.potCardImgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.potCardImgLst.Images.SetKeyName(0, "0.PNG");
            this.potCardImgLst.Images.SetKeyName(1, "1.PNG");
            this.potCardImgLst.Images.SetKeyName(2, "2.PNG");
            this.potCardImgLst.Images.SetKeyName(3, "3.PNG");
            this.potCardImgLst.Images.SetKeyName(4, "4.PNG");
            this.potCardImgLst.Images.SetKeyName(5, "5.PNG");
            this.potCardImgLst.Images.SetKeyName(6, "6.PNG");
            this.potCardImgLst.Images.SetKeyName(7, "7.PNG");
            this.potCardImgLst.Images.SetKeyName(8, "8.PNG");
            this.potCardImgLst.Images.SetKeyName(9, "9.PNG");
            this.potCardImgLst.Images.SetKeyName(10, "10.PNG");
            this.potCardImgLst.Images.SetKeyName(11, "11.PNG");
            this.potCardImgLst.Images.SetKeyName(12, "12.PNG");
            this.potCardImgLst.Images.SetKeyName(13, "13.PNG");
            this.potCardImgLst.Images.SetKeyName(14, "14.PNG");
            this.potCardImgLst.Images.SetKeyName(15, "15.PNG");
            this.potCardImgLst.Images.SetKeyName(16, "16.PNG");
            this.potCardImgLst.Images.SetKeyName(17, "17.PNG");
            this.potCardImgLst.Images.SetKeyName(18, "18.PNG");
            this.potCardImgLst.Images.SetKeyName(19, "19.PNG");
            this.potCardImgLst.Images.SetKeyName(20, "20.PNG");
            this.potCardImgLst.Images.SetKeyName(21, "21.PNG");
            this.potCardImgLst.Images.SetKeyName(22, "22.PNG");
            this.potCardImgLst.Images.SetKeyName(23, "23.PNG");
            this.potCardImgLst.Images.SetKeyName(24, "24.PNG");
            this.potCardImgLst.Images.SetKeyName(25, "25.PNG");
            this.potCardImgLst.Images.SetKeyName(26, "26.PNG");
            this.potCardImgLst.Images.SetKeyName(27, "27.PNG");
            this.potCardImgLst.Images.SetKeyName(28, "28.PNG");
            this.potCardImgLst.Images.SetKeyName(29, "29.PNG");
            this.potCardImgLst.Images.SetKeyName(30, "30.PNG");
            this.potCardImgLst.Images.SetKeyName(31, "31.PNG");
            this.potCardImgLst.Images.SetKeyName(32, "32.PNG");
            this.potCardImgLst.Images.SetKeyName(33, "33.PNG");
            this.potCardImgLst.Images.SetKeyName(34, "34.PNG");
            this.potCardImgLst.Images.SetKeyName(35, "35.PNG");
            this.potCardImgLst.Images.SetKeyName(36, "36.PNG");
            this.potCardImgLst.Images.SetKeyName(37, "37.PNG");
            this.potCardImgLst.Images.SetKeyName(38, "38.PNG");
            this.potCardImgLst.Images.SetKeyName(39, "39.PNG");
            this.potCardImgLst.Images.SetKeyName(40, "40.PNG");
            this.potCardImgLst.Images.SetKeyName(41, "41.PNG");
            this.potCardImgLst.Images.SetKeyName(42, "42.PNG");
            this.potCardImgLst.Images.SetKeyName(43, "43.PNG");
            this.potCardImgLst.Images.SetKeyName(44, "44.PNG");
            this.potCardImgLst.Images.SetKeyName(45, "45.PNG");
            this.potCardImgLst.Images.SetKeyName(46, "46.PNG");
            this.potCardImgLst.Images.SetKeyName(47, "47.PNG");
            this.potCardImgLst.Images.SetKeyName(48, "48.PNG");
            this.potCardImgLst.Images.SetKeyName(49, "49.PNG");
            this.potCardImgLst.Images.SetKeyName(50, "50.PNG");
            this.potCardImgLst.Images.SetKeyName(51, "51.PNG");
            this.potCardImgLst.Images.SetKeyName(52, "back.PNG");
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(357, 6);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(361, 79);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 24;
            this.pictureBox_Logo.TabStop = false;
            // 
            // tb_UserPlayer
            // 
            this.tb_UserPlayer.BackColor = System.Drawing.Color.Black;
            this.tb_UserPlayer.ForeColor = System.Drawing.Color.Coral;
            this.tb_UserPlayer.Location = new System.Drawing.Point(504, 290);
            this.tb_UserPlayer.Name = "tb_UserPlayer";
            this.tb_UserPlayer.Size = new System.Drawing.Size(100, 20);
            this.tb_UserPlayer.TabIndex = 32;
            this.tb_UserPlayer.Text = "Your Hand";
            this.tb_UserPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTurn
            // 
            this.lblTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTurn.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTurn.Location = new System.Drawing.Point(201, 271);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(230, 49);
            this.lblTurn.TabIndex = 35;
            // 
            // flpCards
            // 
            this.flpCards.Location = new System.Drawing.Point(17, 364);
            this.flpCards.Name = "flpCards";
            this.flpCards.Size = new System.Drawing.Size(1120, 133);
            this.flpCards.TabIndex = 36;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(28, 87);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(273, 233);
            this.tbLog.TabIndex = 38;
            // 
            // tbBooks
            // 
            this.tbBooks.Location = new System.Drawing.Point(791, 87);
            this.tbBooks.Multiline = true;
            this.tbBooks.Name = "tbBooks";
            this.tbBooks.Size = new System.Drawing.Size(258, 223);
            this.tbBooks.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Game Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Books";
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Font = new System.Drawing.Font("Roboto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurns.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTurns.Location = new System.Drawing.Point(477, 191);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(0, 29);
            this.lblTurns.TabIndex = 42;
            // 
            // vS1AIToolStripMenuItem
            // 
            this.vS1AIToolStripMenuItem.Name = "vS1AIToolStripMenuItem";
            this.vS1AIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vS1AIToolStripMenuItem.Text = "1 Computer";
            this.vS1AIToolStripMenuItem.Click += new System.EventHandler(this.vS1AIToolStripMenuItem_Click);
            // 
            // computersToolStripMenuItem
            // 
            this.computersToolStripMenuItem.Name = "computersToolStripMenuItem";
            this.computersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.computersToolStripMenuItem.Text = "2 Computers";
            this.computersToolStripMenuItem.Click += new System.EventHandler(this.computersToolStripMenuItem_Click);
            // 
            // computerToolStripMenuItem
            // 
            this.computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            this.computerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.computerToolStripMenuItem.Text = "1 Computer";
            this.computerToolStripMenuItem.Click += new System.EventHandler(this.computerToolStripMenuItem_Click);
            // 
            // computerToolStripMenuItem1
            // 
            this.computerToolStripMenuItem1.Name = "computerToolStripMenuItem1";
            this.computerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.computerToolStripMenuItem1.Text = "2 Computer";
            this.computerToolStripMenuItem1.Click += new System.EventHandler(this.computerToolStripMenuItem1_Click);
            // 
            // computerToolStripMenuItem2
            // 
            this.computerToolStripMenuItem2.Name = "computerToolStripMenuItem2";
            this.computerToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.computerToolStripMenuItem2.Text = "3 Computer";
            this.computerToolStripMenuItem2.Click += new System.EventHandler(this.computerToolStripMenuItem2_Click);
            // 
            // computerToolStripMenuItem3
            // 
            this.computerToolStripMenuItem3.Name = "computerToolStripMenuItem3";
            this.computerToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.computerToolStripMenuItem3.Text = "1 Computer";
            this.computerToolStripMenuItem3.Click += new System.EventHandler(this.computerToolStripMenuItem3_Click);
            // 
            // computerToolStripMenuItem4
            // 
            this.computerToolStripMenuItem4.Name = "computerToolStripMenuItem4";
            this.computerToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.computerToolStripMenuItem4.Text = "2 Computer";
            this.computerToolStripMenuItem4.Click += new System.EventHandler(this.computerToolStripMenuItem4_Click);
            // 
            // computerToolStripMenuItem5
            // 
            this.computerToolStripMenuItem5.Name = "computerToolStripMenuItem5";
            this.computerToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.computerToolStripMenuItem5.Text = "3 Computer";
            this.computerToolStripMenuItem5.Click += new System.EventHandler(this.computerToolStripMenuItem5_Click);
            // 
            // computerToolStripMenuItem6
            // 
            this.computerToolStripMenuItem6.Name = "computerToolStripMenuItem6";
            this.computerToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.computerToolStripMenuItem6.Text = "4 Computer";
            this.computerToolStripMenuItem6.Click += new System.EventHandler(this.computerToolStripMenuItem6_Click);
            // 
            // PbDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1162, 515);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBooks);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.flpCards);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.tb_UserPlayer);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PbDraw";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        public System.Windows.Forms.ImageList potCardImgLst;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TextBox tb_UserPlayer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.FlowLayoutPanel flpCards;
        public System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem2;
        private System.Windows.Forms.TextBox tbBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.ToolStripMenuItem vS1AIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem6;
    }
}


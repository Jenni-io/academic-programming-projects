namespace GuessingGameGUI
{
    partial class FrmGuessingGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstNumbers = new ListBox();
            lblGuesANumber = new Label();
            lblIncorrectGuesses = new Label();
            lblNumRemaining = new Label();
            lblOutputCountWrongGuess = new Label();
            lblOutPutNumCountRemaining = new Label();
            stbMain = new StatusStrip();
            stblOutput = new ToolStripStatusLabel();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mnuMain = new MenuStrip();
            stbMain.SuspendLayout();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // lstNumbers
            // 
            lstNumbers.BackColor = SystemColors.MenuBar;
            lstNumbers.ColumnWidth = 28;
            lstNumbers.FormattingEnabled = true;
            lstNumbers.ItemHeight = 25;
            lstNumbers.Location = new Point(12, 48);
            lstNumbers.MultiColumn = true;
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(308, 254);
            lstNumbers.TabIndex = 2;
            lstNumbers.Click += lstNumbers_Click;
            // 
            // lblGuesANumber
            // 
            lblGuesANumber.AutoSize = true;
            lblGuesANumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuesANumber.Location = new Point(35, 24);
            lblGuesANumber.Name = "lblGuesANumber";
            lblGuesANumber.Size = new Size(265, 21);
            lblGuesANumber.TabIndex = 1;
            lblGuesANumber.Text = "Guess a number between 1 and 100!";
            // 
            // lblIncorrectGuesses
            // 
            lblIncorrectGuesses.AutoSize = true;
            lblIncorrectGuesses.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncorrectGuesses.Location = new Point(12, 319);
            lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            lblIncorrectGuesses.Size = new Size(105, 15);
            lblIncorrectGuesses.TabIndex = 3;
            lblIncorrectGuesses.Text = "Incorrect Guesses: ";
            // 
            // lblNumRemaining
            // 
            lblNumRemaining.AutoSize = true;
            lblNumRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumRemaining.Location = new Point(165, 319);
            lblNumRemaining.Name = "lblNumRemaining";
            lblNumRemaining.Size = new Size(119, 15);
            lblNumRemaining.TabIndex = 5;
            lblNumRemaining.Text = "Numbers Remaining:";
            // 
            // lblOutputCountWrongGuess
            // 
            lblOutputCountWrongGuess.BorderStyle = BorderStyle.Fixed3D;
            lblOutputCountWrongGuess.FlatStyle = FlatStyle.Flat;
            lblOutputCountWrongGuess.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutputCountWrongGuess.Location = new Point(113, 313);
            lblOutputCountWrongGuess.Name = "lblOutputCountWrongGuess";
            lblOutputCountWrongGuess.Size = new Size(30, 27);
            lblOutputCountWrongGuess.TabIndex = 4;
            lblOutputCountWrongGuess.Text = "0";
            lblOutputCountWrongGuess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOutPutNumCountRemaining
            // 
            lblOutPutNumCountRemaining.BorderStyle = BorderStyle.Fixed3D;
            lblOutPutNumCountRemaining.FlatStyle = FlatStyle.Flat;
            lblOutPutNumCountRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutPutNumCountRemaining.Location = new Point(290, 313);
            lblOutPutNumCountRemaining.Name = "lblOutPutNumCountRemaining";
            lblOutPutNumCountRemaining.Size = new Size(30, 27);
            lblOutPutNumCountRemaining.TabIndex = 6;
            lblOutPutNumCountRemaining.Text = "0";
            lblOutPutNumCountRemaining.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // stbMain
            // 
            stbMain.Items.AddRange(new ToolStripItem[] { stblOutput });
            stbMain.Location = new Point(0, 348);
            stbMain.Name = "stbMain";
            stbMain.Size = new Size(332, 22);
            stbMain.TabIndex = 7;
            stbMain.Text = "statusStrip1";
            // 
            // stblOutput
            // 
            stblOutput.Name = "stblOutput";
            stblOutput.RightToLeftAutoMirrorImage = true;
            stblOutput.Size = new Size(317, 17);
            stblOutput.Spring = true;
            stblOutput.Text = "Click a number to guess this number!";
            stblOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(132, 22);
            newGameToolStripMenuItem.Text = "&New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(132, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // mnuMain
            // 
            mnuMain.BackColor = SystemColors.Control;
            mnuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mnuMain.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(332, 24);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // FrmGuessingGame
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 370);
            Controls.Add(stbMain);
            Controls.Add(lblOutPutNumCountRemaining);
            Controls.Add(lblOutputCountWrongGuess);
            Controls.Add(lblNumRemaining);
            Controls.Add(lblIncorrectGuesses);
            Controls.Add(lblGuesANumber);
            Controls.Add(lstNumbers);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = mnuMain;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmGuessingGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guessing Game";
            Load += FrmGuessingGame_Load;
            stbMain.ResumeLayout(false);
            stbMain.PerformLayout();
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumbers;
        private Label lblGuesANumber;
        private Label lblIncorrectGuesses;
        private Label lblNumRemaining;
        private Label lblOutputCountWrongGuess;
        private Label lblOutPutNumCountRemaining;
        private StatusStrip stbMain;
        private ToolStripStatusLabel stblOutput;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip mnuMain;
    }
}


namespace assignment2FinalVersionComp60
{
    partial class Form1
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
            this.player1Name = new System.Windows.Forms.TextBox();
            this.player1NameLabel = new System.Windows.Forms.Label();
            this.targetWord = new System.Windows.Forms.TextBox();
            this.targetWordLabel = new System.Windows.Forms.Label();
            this.initialize = new System.Windows.Forms.Button();
            this.guess = new System.Windows.Forms.TextBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player2NameLabel = new System.Windows.Forms.Label();
            this.player1CurrentScore = new System.Windows.Forms.TextBox();
            this.player1CurrentScoreLabel = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.TextBox();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.startNewGuess = new System.Windows.Forms.Button();
            this.prize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prize)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Name
            // 
            this.player1Name.Location = new System.Drawing.Point(83, 173);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(103, 27);
            this.player1Name.TabIndex = 0;
            // 
            // player1NameLabel
            // 
            this.player1NameLabel.AutoSize = true;
            this.player1NameLabel.Location = new System.Drawing.Point(83, 203);
            this.player1NameLabel.Name = "player1NameLabel";
            this.player1NameLabel.Size = new System.Drawing.Size(105, 20);
            this.player1NameLabel.TabIndex = 1;
            this.player1NameLabel.Text = "Player 1 Name";
            // 
            // targetWord
            // 
            this.targetWord.Location = new System.Drawing.Point(531, 173);
            this.targetWord.Name = "targetWord";
            this.targetWord.ReadOnly = true;
            this.targetWord.Size = new System.Drawing.Size(113, 27);
            this.targetWord.TabIndex = 2;
            // 
            // targetWordLabel
            // 
            this.targetWordLabel.AutoSize = true;
            this.targetWordLabel.Location = new System.Drawing.Point(541, 203);
            this.targetWordLabel.Name = "targetWordLabel";
            this.targetWordLabel.Size = new System.Drawing.Size(90, 20);
            this.targetWordLabel.TabIndex = 3;
            this.targetWordLabel.Text = "Target Word";
            // 
            // initialize
            // 
            this.initialize.Location = new System.Drawing.Point(117, 385);
            this.initialize.Name = "initialize";
            this.initialize.Size = new System.Drawing.Size(111, 32);
            this.initialize.TabIndex = 4;
            this.initialize.Text = "Initialize";
            this.initialize.UseVisualStyleBackColor = true;
            this.initialize.Click += new System.EventHandler(this.initialize_Click);
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(106, 264);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(79, 27);
            this.guess.TabIndex = 5;
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(106, 294);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(80, 20);
            this.guessLabel.TabIndex = 6;
            this.guessLabel.Text = "Your Guess";
            // 
            // player2Name
            // 
            this.player2Name.Location = new System.Drawing.Point(277, 173);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(155, 27);
            this.player2Name.TabIndex = 7;
            // 
            // player2NameLabel
            // 
            this.player2NameLabel.AutoSize = true;
            this.player2NameLabel.Location = new System.Drawing.Point(296, 203);
            this.player2NameLabel.Name = "player2NameLabel";
            this.player2NameLabel.Size = new System.Drawing.Size(105, 20);
            this.player2NameLabel.TabIndex = 8;
            this.player2NameLabel.Text = "Player 2 Name";
            // 
            // player1CurrentScore
            // 
            this.player1CurrentScore.Location = new System.Drawing.Point(296, 264);
            this.player1CurrentScore.Name = "player1CurrentScore";
            this.player1CurrentScore.ReadOnly = true;
            this.player1CurrentScore.Size = new System.Drawing.Size(102, 27);
            this.player1CurrentScore.TabIndex = 9;
            // 
            // player1CurrentScoreLabel
            // 
            this.player1CurrentScoreLabel.AutoSize = true;
            this.player1CurrentScoreLabel.Location = new System.Drawing.Point(278, 294);
            this.player1CurrentScoreLabel.Name = "player1CurrentScoreLabel";
            this.player1CurrentScoreLabel.Size = new System.Drawing.Size(154, 20);
            this.player1CurrentScoreLabel.TabIndex = 10;
            this.player1CurrentScoreLabel.Text = "Player 1 Current Score";
            // 
            // player2Score
            // 
            this.player2Score.Location = new System.Drawing.Point(506, 264);
            this.player2Score.Name = "player2Score";
            this.player2Score.ReadOnly = true;
            this.player2Score.Size = new System.Drawing.Size(125, 27);
            this.player2Score.TabIndex = 11;
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Location = new System.Drawing.Point(506, 294);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(154, 20);
            this.player2ScoreLabel.TabIndex = 12;
            this.player2ScoreLabel.Text = "Player 2 Current Score";
            // 
            // startNewGuess
            // 
            this.startNewGuess.Location = new System.Drawing.Point(410, 385);
            this.startNewGuess.Name = "startNewGuess";
            this.startNewGuess.Size = new System.Drawing.Size(154, 32);
            this.startNewGuess.TabIndex = 13;
            this.startNewGuess.Text = "Start New Guess\r\n";
            this.startNewGuess.UseVisualStyleBackColor = true;
            this.startNewGuess.Click += new System.EventHandler(this.startNewGuess_Click);
            // 
            // prize
            // 
            this.prize.Image = global::assignment2FinalVersionComp60.Properties.Resources.prizeWheel;
            this.prize.Location = new System.Drawing.Point(277, 44);
            this.prize.Name = "prize";
            this.prize.Size = new System.Drawing.Size(142, 89);
            this.prize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prize.TabIndex = 14;
            this.prize.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prize);
            this.Controls.Add(this.startNewGuess);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1CurrentScoreLabel);
            this.Controls.Add(this.player1CurrentScore);
            this.Controls.Add(this.player2NameLabel);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.initialize);
            this.Controls.Add(this.targetWordLabel);
            this.Controls.Add(this.targetWord);
            this.Controls.Add(this.player1NameLabel);
            this.Controls.Add(this.player1Name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.prize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.Label player1NameLabel;
        private System.Windows.Forms.TextBox targetWord;
        private System.Windows.Forms.Label targetWordLabel;
        private System.Windows.Forms.Button initialize;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.Label player2NameLabel;
        private System.Windows.Forms.TextBox player1CurrentScore;
        private System.Windows.Forms.Label player1CurrentScoreLabel;
        private System.Windows.Forms.TextBox player2Score;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Button startNewGuess;
        private System.Windows.Forms.PictureBox prize;
    }
}


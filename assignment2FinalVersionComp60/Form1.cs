using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name:Seda Dadak
//Purpose: Create a word guessing game


namespace assignment2FinalVersionComp60
{
    public partial class Form1 : Form
    {
        Player player1;
        Game game1;
        public Form1()
        {
            InitializeComponent();
        }

        public string GenerateHidden(int index)
        {
            string hiddenWord;
            char[] hiddenWordArray = new char[index];
            for (int ctr = 0; ctr < index; ctr++)
            {
                hiddenWordArray[ctr] = '-';
            }
            return hiddenWord = new string(hiddenWordArray);
        }

        private void initialize_Click(object sender, EventArgs e)
        {
            player1 = new Player(player1Name.Text);
            game1 = new Game();
            string hiddenWord = game1.CurrentTarget;
            int index = hiddenWord.Length;
            targetWord.Text = GenerateHidden(index);
            prize.Image = assignment2FinalVersionComp60.Properties.Resources._0score;
            MessageBox.Show("player" + game1.NumTurn + "turn");
        }

        private void startNewGuess_Click(object sender, EventArgs e)
        {
            string hiddenWord = game1.CurrentTarget;
            int index = hiddenWord.Length;
            char[] hiddenWordArray = new char[index];
            for (int ctr = 0; ctr < index; ctr++)
            {
                hiddenWordArray[ctr] = targetWord.Text[ctr];
            }
            bool isMatched = false;
            for (int i=0; i<index;i++)
            {
                if (guess.Text[0] == hiddenWord[i])
                {
                    hiddenWordArray[i] = guess.Text[0];
                    game1.Scoreboard[game1.NumTurn - 1] += game1.CurrentTurnScore;
                    isMatched = true;
                }
            }
            if (!isMatched)
            {
                MessageBox.Show(guess.Text[0] + " Not Found");
                if(game1.NumTurn == 1)
                {
                    game1.NumTurn = 2;
                }
                else
                {
                    game1.NumTurn = 1;
                }
            }

            targetWord.Text = new string(hiddenWordArray);
            bool isGameFinished = true; 
            for (int i = 0; i < index; i++)
            {
                if (targetWord.Text[i]=='-')
                {
                    isGameFinished=false;
                    break;
                }
            }
            if (isGameFinished) 
            { 
                if(Int32.Parse(player1CurrentScore.Text) > Int32.Parse(player2Score.Text))
                {
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show(player1Name.Text+ " has the highest score " , " Do you want to play again? " , MessageBoxButtons.YesNo);
                    if(dialogResult == DialogResult.Yes)
                    {
                        targetWord.Text = GenerateHidden(index);
                    }
                    else if (dialogResult== DialogResult.No)
                    {
                        MessageBox.Show("Game over ");
                    }
                }    
                else
                {
                    DialogResult dialogResult;
                    dialogResult = MessageBox.Show(player2Name.Text + " has the highest score " , " Do you want to play again? " , MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        targetWord.Text = GenerateHidden(index);
                       
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Game over ");
                    }
                }
                    
            }
            if (game1.CurrentTurnScore == 10)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._10score;

            }
            else if (game1.CurrentTurnScore == 25)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._25score;

            }
            else if (game1.CurrentTurnScore == 75)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._75score;

            }
            else if (game1.CurrentTurnScore == 0)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._0score;

            }
            else if (game1.CurrentTurnScore == 100)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._100score;

            }
            else if (game1.CurrentTurnScore == 50)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._50score;

            }
            else if (game1.CurrentTurnScore == 0)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._30score;

            }
            else if (game1.CurrentTurnScore == 100)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._80score;

            }
            else if (game1.CurrentTurnScore == 50)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._20;
            }
            else if (game1.CurrentTurnScore == 50)
            {
                prize.Image = assignment2FinalVersionComp60.Properties.Resources._40;
            }

            game1.CurrentTurnScore = game1.changeCurrentTurnScore();
            player1CurrentScore.Text = " " + game1.Scoreboard[0];
            player2Score.Text = " " + game1.Scoreboard[1];
            MessageBox.Show("Scoreboard\n" + "Player1: " + game1.Scoreboard[0] +"\n" + "Player2: " + game1.Scoreboard[1]);
        }
    }
}

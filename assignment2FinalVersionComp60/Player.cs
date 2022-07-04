using System;
using System.Collections.Generic;
using System.Text;
//Name:Seda Dadak
//Purpose: Create a word guessing game


namespace assignment2FinalVersionComp60
{
    class Player
    {
        private string playerName;
        private int playerScore;
        private int numberOfWin;
        private int numberOfLosses;


        public Player(string initialPlayerName)
        {
            playerScore = 0;
            numberOfWin = 0;
            numberOfLosses = 0;
        }
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }
        public int PlayerScore
        {
            get
            {
                return playerScore;
            }
            set
            {
                playerScore = value;
            }
        }
        public int NumberOfWin
        {
            get
            {
                return numberOfWin;
            }
            set
            {
                numberOfWin = value;
            }
        }
        public int NumberOfLosses
        {
            get
            {
                return numberOfLosses;
            }
            set
            {
                numberOfLosses = value;
            }
        }
    }
}


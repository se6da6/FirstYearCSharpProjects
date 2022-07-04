using System;
using System.Collections.Generic;
using System.Text;
//Name:Seda Dadak
//Purpose: Create a word guessing game

namespace assignment2FinalVersionComp60
{
    class Game
    {
        private static string[] words = new string[] { "hello", "bye", "good", "bad", "fine", "bad", "funny", "sad", "worried", "welldone" };
        private static int[] prizes = new int[] { 10, 25, 75, 0, 100, 50, 30, 80, 20, 40 };
        string currentTarget;
        int numTurn;
        int currentTurnScore;
        int[] scoreboard = { 0, 0 };

        private void AssignTargetWord()
        {
            Random random = new Random();
            int index = random.Next() % 10;
            currentTarget = words[index];
        }
        public Game()
        {
            AssignTargetWord();
            Random random = new Random();
            numTurn = random.Next() %2 + 1; 
            currentTurnScore = prizes[random.Next() % prizes.Length];
        }
        public int changeCurrentTurnScore()
        {
            Random random = new Random();
            return prizes[random.Next() % prizes.Length];
        }
        public string[] Words
        {
            get
            {
                return words;
            }
        }
        public int[] Prizes
        {
            get
            {
                return prizes;
            }
        }
        public string CurrentTarget
        {
            get
            {
                return currentTarget;

            }

            set
            {
                currentTarget = value;
            }
        }
        public int NumTurn
        {
            get
            {
                return numTurn;
            }
            set
            {
                numTurn = value;
            }
        }
        public int CurrentTurnScore
        {
            get
            {
                return currentTurnScore;
            }
            set
            {
                currentTurnScore = value;
            }
        }
        public int[] Scoreboard
        {
            get
            {
                return scoreboard;

            }
            set
            {
                scoreboard = value;
            }
        }
    }
}


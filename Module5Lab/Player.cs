using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5Lab
{ // I am trying to declare classes. 
    internal class Player
    {
        // keeping taps of three variables for the attributes.
        private string name;
        private int score;
        private int livesLeft;

        // using constructors is a special methods that make new object. (another way of saying new instance of the class)
        public Player()
        {
            // ending the constructor. 
        }

        public Player(string name)
        {
            // setting the name for the new attribute 
            // previously from the constructor method
            this.name = name;
            //end

        }

        public Player(string name, int startingLives)
        {
            // I am setting a number of lives a player has left.
            // value of the name attribute on the player object, and passed to the constructor method. 
            this.name = name;

            // using the value of the livesleft attribute.
            livesLeft = startingLives;
        }

        // we return back to the methods. 

        public int GetScore()
        { // returning back to the score to the player
            return score;
        }

        // adding points to the player's score. 
        public void AddPoints(int totalPoints)
        {
            //adding the total points to the score. 
            score += totalPoints;
        }

        public void Kill() // they can't get negative lives in the video game. 
        {
            if (livesLeft > 0)
            {// removes one of the lives when killed. 
                livesLeft--;
            }
        }

        public int GetLivesLeft()
        {
            // returns the number of lives back to the player. 
            return livesLeft;
        }

    }
}
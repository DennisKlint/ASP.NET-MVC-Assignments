using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutAndViewsAssignment2.Models
{
    static public class GuessingGameModels
    {
        static public int RandomNumberGenerator()
        {
            Random rnd = new Random();
            var number = rnd.Next(1, 101);
            return number;
        }

        internal static string CheckGuess(int guess, int rndNumber)
        {
            if (guess == rndNumber)
            {
                return "You guessed correct!";
            }

            else if (guess >= rndNumber)
            {
                return "Your guess is to high, try again";
            }

            else if (guess <= rndNumber)
            {
                return "Your guess is to low, try again";
            }
            else
            {
                return "You're not meant to see this, how'd you get here??";
            }
        }
    }

}
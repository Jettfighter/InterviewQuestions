using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionsLibrary
{

    /*
     * Problem 1:

        Write a method that takes a string argument and returns whether or not characters in the string have matching brackets. 
        Meaning for every { there is a corresponding } bracket. Return true if they do, return false if they do not. 
        Please unit test with the following use cases (and any others you choose to ensure functionality):
     */
    public static class StringValidator
    {
        /// <summary>
        /// Checks the given string to see if for every '{' there is a '}' and to make sure they are sequenced properly.
        /// </summary>
        /// <param name="str">The string to check for matching brackets</param>
        /// <returns>A boolean marked true if properly matched, and false if not</returns>
        public static bool HasMatchingBrackets(string str)
        {
            bool isMatching = true;

            int openBrackets = 0;
            int closingBrackets = 0;

            foreach (char character in str)
            {
                if (character == '{') openBrackets++;

                else if (character == '}')
                {
                    closingBrackets++;

                    //A greater number of close brackets means it will always be false
                    isMatching = openBrackets >= closingBrackets;
                }

                if (!isMatching)
                {
                    //Breaks from loop early if it can't match, so as to save processing time/power
                    break;
                }
            }

            if (isMatching)
            {
                //Ensures the number of brackets match.
                isMatching = openBrackets == closingBrackets;
            }

            return isMatching;
        }
    }
}

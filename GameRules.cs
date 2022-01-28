using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class GameRules
    {
        public void Write(int limit, string firstWord, int firstNumber, string secondWord, int secondNumber, bool ascendingOrder)
        {
            if (ascendingOrder)
            {
                for (int i = 1; i <= limit; i++)
                {
                    Output(i, firstWord, firstNumber, secondWord, secondNumber);
                }
            }
            else
            {
                for (int i = limit; i >= 1; i--)
                {
                    Output(i, firstWord, firstNumber, secondWord, secondNumber);
                }
            }
        }

        public void Output(int i, string firstWord, int firstNumber, string secondWord, int secondNumber)
        {
            bool isFirst = i % firstNumber == 0;
            bool isSecond = i % secondNumber == 0;

            if (isFirst && isSecond)
            {
                Console.WriteLine(firstWord + secondWord);
            }
            else if (isFirst)
            {
                Console.WriteLine(firstWord);
            }
            else if (isSecond)
            {
                Console.WriteLine(secondWord);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

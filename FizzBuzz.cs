using System;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public static void Run(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                bool isFizz = i % 3 == 0;
                bool isBuzz = i % 5 == 0;

                if (isFizz && isBuzz)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                if (isFizz)
                {
                    Console.WriteLine("Fizz");
                }
                else
                if (isBuzz)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzzJazzFuzz : IGameInterface
    {
         public void Run(int limit)
        {
            FizzBuzz fb = new FizzBuzz();
            fb.Run(limit);

            for (int i = limit; i >= 1; i--)
            {
                bool isJazz = i % 9 == 0;
                bool isFuzz = i % 4 == 0;

                if (isJazz && isFuzz)
                {
                    Console.WriteLine("JazzFuzz");
                }
                else
                if (isJazz)
                {
                    Console.WriteLine("Jazz");
                }
                else
                if (isFuzz)
                {
                    Console.WriteLine("Fuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

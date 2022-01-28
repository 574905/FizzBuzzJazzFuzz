using System;

namespace FizzBuzzGame
{
    class FizzBuzz : GameRules, IGameInterface
    {
        public void Run()
        {
            Write(100, "Fizz", 3, "Buzz", 5, true);
        }
    }
}

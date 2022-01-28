using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzzJazzFuzz : GameRules, IGameInterface
    {
        public void Run()
        {
            Write(100, "Fizz", 3, "Buzz", 5, true);
            Write(100, "Jazz", 9, "Fuzz", 4, false);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzJazzFuzz fbjf = new FizzBuzzJazzFuzz();
            fbjf.Run(100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditinals");
            Console.WriteLine("-----------");
            Console.WriteLine();

            int score;
            string gamertag;

            score = 0;
            gamertag = "BaconBoy3142";
            if (gamertag == "BaconBoy3142")
            {
                score = 1000000;
            }
            Console.WriteLine("Score: " + score);

            Console.ReadKey(true);
        }
    }
}

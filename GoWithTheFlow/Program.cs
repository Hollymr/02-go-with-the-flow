using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp doesn't work?");
            Console.WriteLine("Is lamp plugged in?");
            string answerYes = Console.ReadLine();
            if (answerYes == "yes")
            {
                Console.WriteLine("Is bulb burned out?");

            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

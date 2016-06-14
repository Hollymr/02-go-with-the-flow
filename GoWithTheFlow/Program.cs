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
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Is bulb burned out?");
                answer = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Plug the lamp in!");
            }


            if (answer.ToLower() == "yes")
            { Console.WriteLine("Replace bulb.");
            }

            else
            {
                Console.WriteLine("Repair your lamp");
            }

             

            Console.ReadKey();
        }
    }
}

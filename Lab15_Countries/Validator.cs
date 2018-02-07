using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Countries
{
    class Validator
    {
        public static ConsoleKey CheckMenuSelection (string message)
        {
            Console.WriteLine(message);
            ConsoleKey input = Console.ReadKey().Key;
            while (input != ConsoleKey.D1 && input != ConsoleKey.NumPad1 &&
                input != ConsoleKey.D2 && input != ConsoleKey.NumPad2 &&
                input != ConsoleKey.D3 && input != ConsoleKey.NumPad3 &&
                input != ConsoleKey.D4 && input != ConsoleKey.NumPad4)
            {
                Console.WriteLine($"Invalid input! {message}");
                input = Console.ReadKey().Key;
            }
            return input;
        }

        public static ConsoleKey CheckYorN(string message)
        {
            Console.WriteLine(message);
            ConsoleKey input = Console.ReadKey().Key;
            while (input != ConsoleKey.Y && input != ConsoleKey.N)
            {
                Console.WriteLine($"Invalid input! {message}");
                input = Console.ReadKey().Key;
            }
            return input;
        }

        //public static bool CheckCountryExists(string message)
        //{
        //    Console.WriteLine(message);
        //}

    }
}

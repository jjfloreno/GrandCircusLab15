using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab15_Countries
{
    class CountriesApp
    {
        public bool IsPlaying { get; set; } = true;
        public ConsoleKey UserInput { get; set; }

        public void StartApp()
        {


            Console.WriteLine("Welcome to the Grand Circus Country List Thingy!");
            System.Threading.Thread.Sleep(1000);

            while (IsPlaying)
            {

                PrintMenu();

                UserInput = Validator.CheckMenuSelection("Please enter the number for the action you would like to take:");

                if (UserInput == ConsoleKey.D1 || UserInput == ConsoleKey.NumPad1)
                {
                    PrintCountries();
                }
                else if (UserInput == ConsoleKey.D2 || UserInput == ConsoleKey.NumPad2)
                {
                    AddCountry();
                }
                else if (UserInput == ConsoleKey.D3 || UserInput == ConsoleKey.NumPad4)
                {
                    DeleteCountry();
                }
                else
                {
                    Console.Clear();
                    IsPlaying = false;
                    break;
                }

                KeepPlaying();
            }
        }

        private void PrintMenu()
        {
            IEnumerable<MenuChoices> menu = Enum.GetValues(typeof(MenuChoices)).Cast<MenuChoices>();

            foreach (MenuChoices action in menu)
            {
                Console.WriteLine($"{(int)action}. {action}");
            }
        }

        private void PrintCountries()
        {
            Console.Clear();
            List<string> CountryList = CountriesTextFile.GetCountries("../../countries.txt");

            foreach (string country in CountryList)
            {
                Console.WriteLine(country);
            }
        }

        private void AddCountry()
        {
            Console.Clear();
            Console.Write("Please enter a country to add: ");
            string input = Console.ReadLine();

            CountriesTextFile.WriteCountry("../../countries.txt", input);
        }

        private void DeleteCountry()
        {
            Console.Clear();
            Console.WriteLine("Please enter the country to delete: ");
            string input = Console.ReadLine();

            CountriesTextFile.RemoveCountry("../../countries.txt", input);
        }

        private void KeepPlaying()
        {
            UserInput = Validator.CheckYorN("Would you like to continue? (<Y> to continue <N> to exit)");
            if (UserInput == ConsoleKey.Y)
            {
                Console.Clear();
            }
            else if (UserInput == ConsoleKey.N)
            {
                Console.WriteLine("Farewell!");
                IsPlaying = false;
            }
        }
    }
}

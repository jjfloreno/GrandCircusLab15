using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_Countries
{
    class CountriesTextFile
    {
        public static List<string> GetCountries(string FileName)
        {
            StreamReader Reader = new StreamReader(FileName);

            string CurrentLine = Reader.ReadLine();
            List<string> CountryList = new List<string>();

            while (CurrentLine != null)
            {
                CountryList.Add(CurrentLine);
                CurrentLine = Reader.ReadLine(); //points the reader to the next line
            }

            Reader.Close();

            return CountryList;
        }

        public static void WriteCountry(string FileName, string Input)
        {
            StreamWriter Writer = new StreamWriter(FileName, true);

            Writer.WriteLine(Input);

            Writer.Close();
        }

        public static void RemoveCountry(string FileName, string Input)
        {
            StreamReader Reader = new StreamReader(FileName);

            string CurrentLine = Reader.ReadLine();
            List<string> CountryList = new List<string>();

            while (CurrentLine != null)
            {
                CountryList.Add(CurrentLine);
                CurrentLine = Reader.ReadLine(); //points the reader to the next line
            }
            Reader.Close();

            if (CountryList.Contains(Input))
            {
                CountryList.Remove(Input);
                StreamWriter Writer = new StreamWriter(FileName);

                foreach(string country in CountryList)
                {
                    Writer.WriteLine(country);
                }


                Writer.Close();
            }
            else
            {
                Console.WriteLine($"{Input} is not a country on this list!");
            }
        }
    }
}

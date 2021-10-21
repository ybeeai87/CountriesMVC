using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    //controller
    class CountryController
    {
        //properties
        List<Country> CountryDb;
        //constructor
        public CountryController(List<Country> _countryDb)
        {
            CountryDb = _countryDb;
        }
        //methods
        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }
        public void WelcomeAction()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                CountryListView countryListView = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country number from the following list:");
                CountryListAction();
                break;
            }
        }
        public void CountryListAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            clv.Display();
            int input = Validator.Validator.GetNumber();
            while (true)
            {
                if (input < 1 || input > CountryDb.Count)
                {
                    Console.WriteLine("That number was not in range.");
                }
                else
                {
                    CountryAction(CountryDb[input]);
                }
                break;
            }
            Validator.Validator.getContinue("Would you like to learn about another country?");       
        }
    }
    //Console.ForegroundColor = ConsoleColor.InsertColorHere

}


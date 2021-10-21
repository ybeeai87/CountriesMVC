using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    //view
    class CountryView
    {
        //properties
        public Country DisplayCountry { get; set; }
        //constructor
        public CountryView (Country c)
        {
            DisplayCountry = c;
        }
        public void Display()
        {
            Console.WriteLine($"{DisplayCountry.Name}, {DisplayCountry.Continent}");
            foreach(string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}

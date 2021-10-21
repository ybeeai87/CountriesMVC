using System;
using System.Collections.Generic;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {

            //cw.(Country.Colors) = List<String>;        but cw(Country.Colors[0]) = "Red";

            List<Country> Countries = new List<Country>
            {
                new Country("Canada","North America", new List<string>{"Red","White" }),
                new Country("Brazil", "South America",new List<string>{"Green","Yellow","Blue" }),
                new Country("Japan", "Asia", new List<string> {"Red", "White" }),
                new Country("Spain", "Europe", new List<string> {"Red", "Yellow" }),
                new Country("Ivory Coast", "Africa", new List<string>{"Orange","White","Green" }),
                new Country("Australia", "Australia", new List<string>{"Blue","Red","White" })
            };

            CountryController Country1 = new CountryController(Countries);
            Country1.WelcomeAction();
        }
    }
}

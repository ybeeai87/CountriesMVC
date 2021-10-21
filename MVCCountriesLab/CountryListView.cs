using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryListView
    {
        //properties
        public List<Country> Countries;

        //constructor

        public List<Country> countries
        {
            get { return this.Countries; }
            set { this.Countries = value; }
        }

        public CountryListView(List<Country> countries)
        {
            this.Countries = countries;
        }

        //method
        public void Display()
        {
            for(int i = 0; i <Countries.Count; i++)
            {
                Console.WriteLine($"{i}. {Countries[i].Name}");
            }
        }
    }
}

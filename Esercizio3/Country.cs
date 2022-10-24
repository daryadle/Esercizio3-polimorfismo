using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    internal class Country:IEuropeanUnion
    {
        public string CountryName { get; set; }
        public City CityName { get; set; }=new City();

        public void Contratto(string country)
        {
            Console.WriteLine(country+" ha fatto contratto con Eropean Union");
        }
    }
}

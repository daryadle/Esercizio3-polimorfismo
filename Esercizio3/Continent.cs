using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    internal class Continent
    {
        public string ContinentName { get; set; }
        public Country CountryName { get; set; }=new Country();
    }
}

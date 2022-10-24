using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3
{
    internal class Citizen
    {
        public City City { get; set; }=new City();
        public Country Country { get; set; }=new Country();
        public Continent Continent { get; set; } = new Continent();                              

    }
}

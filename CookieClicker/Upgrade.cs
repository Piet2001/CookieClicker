using System;
using System.Collections.Generic;
using System.Text;

namespace CookieClicker
{
    public class Upgrade
    {
        public string Naam { get; private set; }
        public int Kps { get; private set; }
        public int Prijs { get; set; }
        public int PrijsInterval { get; private set; }
        public int Aantal { get; set; }

        public Upgrade(string naam,int kps, int prijs, int prijsinterval)
        {
            Naam = naam;
            Kps = kps;
            Prijs = prijs;
            PrijsInterval = prijsinterval;
            Aantal = 0;
        }
    }
}

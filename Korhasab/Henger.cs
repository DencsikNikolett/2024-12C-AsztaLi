using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{
    class Henger : Kor //Származtatás
    {
        //Osztályváltozók
        private double magassag, terfogat;
        
        public Henger(double r, double m)
        {
            this.sugar = r;
            this.magassag = m;
            SetKerulet();
            SetTerulet();
            this.terfogat = this.terulet * this.magassag;
        }

        public double GetTerfogat()
        {
            return this.terfogat;
        }
        public double GetMagassag()
        {
            return this.magassag;
        }
    }
}

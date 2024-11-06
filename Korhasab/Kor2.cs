using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{
    class Kor2
    {
        //Osztály/Tag változók
        private double sugar, 
            kerulet, 
            terulet;



        //Konstruktorok
        public Kor2() { }

        public Kor2(double r)
        {
            this.sugar = r;
            szamitasok();

        }



        //Metódusok
        public void SetSugar(double r)
        {
            this.sugar = r;
            szamitasok();
        }

        //Privát metodusok
        private void kalkKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }

        private double kalkTerulet(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        private void szamitasok()
        {
            kalkKerulet();
            this.terulet = kalkTerulet(this.sugar);
        }
        public double GetKerulet()
        {
            return this.kerulet;
        }
        public double GetTerulet()
        {
            return this.terulet;
        }
        public double GetSugar()
        {
            return this.sugar;
        }
    }
}

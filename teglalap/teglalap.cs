using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{

    class Teglalap
    {
        //Az osztály feladata a sugárból kiszámítja a
        //kör területét és kerületét

        //Osztályváltozók

        private double a_old, b_old, terulet, kerulet;


        //Konstruktorok

        public Teglalap() { }

        public Teglalap(double a, double b)
        {

            this.a_old = a;
            this.b_old = b;


        }

        //Metódusok

        public void ReadBoldal(double b)
        {
            this.b_old = b;
        }
        public void ReadAoldal(double a)
        {
            this.a_old = a;
        }


        public void SetKerulet()
        {
            this.kerulet = a_old + b_old * 2;
        }

        public void SetTerulet()
        {
            this.terulet = a_old * b_old;
        }
        public double GetKerulet()
        {
            return this.kerulet;
        }
        public double GetTerulet()
        {
            return this.terulet;
        }
        public double GetAold()
        {
            return this.a_old;
        }
        public double GetBold()
        {
            return this.b_old;
        }

    }
}

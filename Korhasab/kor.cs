using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{
    class Kor
    {
        //Az osztály feladata a sugárból kiszámítja a
        //kör területét és kerületét

        //Osztályváltozók
        //Osztályban lévő metodusok elérjék egymás--->objektum


        private double sugar,
            terulet,
            kerulet;

        //Konstruktorok(létrehoz)
        //szerepe: példányosítás, az osztályból objektum példányokat hoz létre.
        public Kor(){}

        public Kor(double r)
        {

            this.sugar = r;

        }
        //Public Metódusok
        //Azt határozza meg hogy az osztályon kívül más osztályok is hozzáférnek.

        //Private Metódusok
        //Az osztályon kívül nem lehet látni,hozzá férni. 
        //Egységbe zárás, csak ellenörzötten metóduson keresztül férhetek hozzá.

        //Metódusok
        //Van láthatóságuk, van visszatérési értékük(metodus futása után vissza ad egy adott értéket), 
        //a 'void'-nál nincs vissza adott érték azaz null.

        //Paraméter lista
        //Formális paraméter: amelyek a deklarációban szerepelnek '(double r)'.
        //Aktuális paraméter: konkrétan meg adom az értéket.

        //A változónak két metódussal is tudunk értéket adni!



        public void ReadSugar(double r)
        {
            this.sugar = r;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }

        public void SetTerulet()
        {
            double eredmeny1 = 0.0,
                   eredmeny2 = 0.0;
            eredmeny1 = this.terulet = this.sugar * this.sugar * Math.PI;

            eredmeny2 = this.terulet = Math.Pow(this.sugar, 2);

            if (eredmeny1 == eredmeny2)
            {

                this.terulet = eredmeny1;
                    
            }
            else
            {
                Console.WriteLine($"Eredmény1 {eredmeny1} != Eredmény2 {eredmeny2}");
            }
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

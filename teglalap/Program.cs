using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhasab
{
    class Program
    {
        static void Main(string[] args)
        {
            // A kör osztályok felhasználása
            #region 1. objektum
            // 1. Objektum
            Teglalap k1 = new Teglalap();
            k1.ReadAoldal(15.0); // Sugár megadása
            k1.ReadBoldal(10.0); // Sugár megadása
            k1.SetKerulet(); //Kiszámoljuk a Kerületet
            k1.SetTerulet(); //Kiszámoljuk a Területet

            Console.WriteLine($"A {k1.GetAold()}, {k1.GetBold()} oldalú téglalap kerülete {k1.GetKerulet()}, területe {k1.GetTerulet()} ");
            #endregion EOf 1. objektum
            #region 2. objektum
            Teglalap k2 = new Teglalap();
            k2.ReadAoldal(25.0);
            k2.ReadBoldal(20.0);
            k2.SetKerulet();
            k2.SetTerulet();

            Console.WriteLine($"A {k2.GetAold()}, {k2.GetBold()} oldalú téglalap kerülete {k2.GetKerulet()}, területe {k2.GetTerulet()} ");

            #endregion EOf 2. objektum
            Console.ReadKey();

        }
    }
}
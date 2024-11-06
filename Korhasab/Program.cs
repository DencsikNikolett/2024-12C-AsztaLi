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
            // A Kor osztály felhasználása
            #region 1. objektum
            // 1. Objektum
            Kor k1 = new Kor(); //Objektum példány létrehozása üresen
            k1.ReadSugar(15.0); // Sugár megadása
            k1.SetKerulet(); //Kiszámoljuk a Kerületet
            k1.SetTerulet(); //Kiszámoljuk a Területet
            Console.WriteLine($"A {k1.GetSugar()} sugarú kör kerülete {k1.GetKerulet()}, területe {k1.GetTerulet()} ");
            #endregion EOf 1. objektum

            #region 2. objektum
            Kor k2 = new Kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();
            Console.WriteLine($"A {k2.GetSugar()} sugarú kör kerülete {k2.GetKerulet()}, területe {k2.GetTerulet()} ");
            #endregion EOf 2. objektum

            #region Kor2 hasznalata
            Kor2 k5 = new Kor2(29.5);
            Console.WriteLine($"\n\nA kör2 adatai: \nsugár={k5.GetSugar()}, \nKerület={k5.GetKerulet()}, \nTerület={k5.GetTerulet()}");
            #endregion EOf Kor2 hasznalata

            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class KivetelClass
    {
        //Nincs kivétel kezelés
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivételkezelés\nAdjon meg egy karaktert!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám: {0}", szam);
            Console.ReadLine();
        }
        //Általános kivitelezés
        public void KivKezAlt()
        {
            Console.WriteLine("\nHiba objektum nélküli kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch
            {
                Console.WriteLine("Hibás adat");
                throw;
            }
            Console.ReadKey();
        }
        //Őshiba objektummal
        public void KivKezOs()
        {
            Console.WriteLine("\nŐs hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }

    }
}

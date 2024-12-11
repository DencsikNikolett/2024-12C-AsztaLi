using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOP2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Hibakezeles
    {
        public class Program
        {
            public static void Main()
            {
                try
                {
                    HTipus haromszog1 = new HTipus(3, 4, 5);
                    haromszog1.Kiir();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba: {ex.Message}");
                }

                try
                {
                    HTipus haromszog2 = new HTipus(-1, 4, 5); // Ez hibát fog dobni
                    haromszog2.Kiir();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba: {ex.Message}");
                }

                try
                {
                    HTipus haromszog3 = new HTipus(1, 2, 3); // Ez nem háromszög
                    haromszog3.Kiir();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba: {ex.Message}");
                }
            }
        }

    }

}

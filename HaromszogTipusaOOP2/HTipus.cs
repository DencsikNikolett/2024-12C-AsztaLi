using System;

namespace HaromszogTipusaOOP2
{
    public class HTipus
    {
        protected int a, b, c;

        public HTipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Ellenőrzi, hogy az oldalak háromszöget alkotnak-e
        public bool HaromszogE()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Ellenőrzi, hogy derékszögű háromszög-e
        public bool DerekszoguE()
        {
            if (!HaromszogE()) return false;
            int[] sides = { a, b, c };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        // Ellenőrzi, hogy egyenlő szárú háromszög-e
        public bool EgyenloSzarue()
        {
            if (!HaromszogE()) return false;
            return a == b || a == c || b == c;
        }

        // Ellenőrzi, hogy egyenlő oldalú háromszög-e
        public bool EgyenloOldaluE()
        {
            if (!HaromszogE()) return false;
            return a == b && b == c;
        }

        // Számolja a háromszög területét (Heron-képlet)
        public double Terulet()
        {
            if (!HaromszogE()) throw new InvalidOperationException("Az adatok nem alkotnak háromszöget.");
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        // Információ kiírása
        public void Kiir()
        {
            Console.WriteLine($"Oldalak: a={a}, b={b}, c={c}");
            Console.WriteLine(HaromszogE() ? "Ez egy háromszög." : "Ez nem háromszög.");
            if (HaromszogE())
            {
                Console.WriteLine(DerekszoguE() ? "Ez egy derékszögű háromszög." : "Ez nem derékszögű háromszög.");
                Console.WriteLine(EgyenloSzarue() ? "Ez egy egyenlő szárú háromszög." : "Ez nem egyenlő szárú háromszög.");
                Console.WriteLine(EgyenloOldaluE() ? "Ez egy egyenlő oldalú háromszög." : "Ez nem egyenlő oldalú háromszög.");
                Console.WriteLine($"A háromszög területe: {Terulet():0.00}");
            }
        }
    }
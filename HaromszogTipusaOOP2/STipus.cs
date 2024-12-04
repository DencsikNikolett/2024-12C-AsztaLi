using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOP2
{
    class STipus
    {
        private int a, b, c;

        public STipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool Ervenyesharomszog()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public bool Derekszoguharomszog()
        {
            if (!Ervenyesharomszog()) return false;
            int[] oldalak = {a, b, c };
            Array.Sort(oldalak);
            return (oldalak[0] * oldalak[0] + oldalak[1] * oldalak[1] == oldalak[2] * oldalak[2]);
        }

        public bool EgyenloSzaruHaromszog()
        {
            if (!Ervenyesharomszog()) return false;
            return (a == b) || (a == c) || (b == c);
        }

        public bool EgyenloOldaluHaromszog()
        {
            if (!Ervenyesharomszog()) return false;
            return (a == b) && (b == c);
        }

        public double Terulet()
        {
            if (!Ervenyesharomszog()) throw new InvalidOperationException("Nem érvényes a háromszög.");
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HTipus haromszog1 - new STipus(1, 4, 5);
            Console.WriteLine($"Érvényes háromszög: {haromszog1.ErvenyesHaromszog()}"); 
            Console.WriteLine($"Érvényes háromszög: {haromszog1.ErvenyesHaromszog()}");
            Console.WriteLine($"Érvényes háromszög: {haromszog1.ErvenyesHaromszog()}");
            Console.WriteLine($"Érvényes háromszög: {haromszog1.ErvenyesHaromszog()}");
            Console.WriteLine($"Érvényes háromszög: {haromszog1.ErvenyesHaromszog()}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macskak
{
    class Program
    {

        enum Animals { Cat, Dog, Tiger, Wolf};

        static void Main(string[] args)
        {
            Animals b = Animals.Wolf;
            Animals c = Animals.Cat;

            if (b == Animals.Wolf)
            {
                Console.WriteLine("A b állat Wolf.");
            }
            if (c == Animals.Cat)
            {
                Console.WriteLine("A c állat Cat.");
            }
            Console.ReadLine();
        }

    }
}

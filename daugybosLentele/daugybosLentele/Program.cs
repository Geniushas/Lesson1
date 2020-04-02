using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daugybosLentele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parasykite savo skaiciu: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Daugybos lentele su jusu skaiciais: ");
            Console.WriteLine(skaicius + " * 1 = " + skaicius * 1);
            Console.WriteLine(skaicius + " * 2 = " + skaicius * 2);
            Console.WriteLine(skaicius + " * 3 = " + skaicius * 3);
            Console.WriteLine(skaicius + " * 4 = " + skaicius * 4);
            Console.WriteLine(skaicius + " * 5 = " + skaicius * 5);
            Console.WriteLine(skaicius + " * 6 = " + skaicius * 6);
            Console.WriteLine(skaicius + " * 7 = " + skaicius * 7);
            Console.WriteLine(skaicius + " * 8 = " + skaicius * 8);
            Console.WriteLine(skaicius + " * 9 = " + skaicius * 9);
            Console.WriteLine(skaicius + " * 10 = " + skaicius * 10);

            Console.ReadLine();
        }
    }
}

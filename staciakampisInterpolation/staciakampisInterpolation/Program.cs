using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staciakampisInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite simboli, is kurio bus nupiestas staciakampis: ");
            string simbolis = Console.ReadLine();

            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");
            Console.WriteLine($"{simbolis} {simbolis}");
            Console.WriteLine($"{simbolis} {simbolis}");
            Console.WriteLine($"{simbolis} {simbolis}");
            Console.WriteLine($"{simbolis}{simbolis}{simbolis}");

            Console.ReadLine();
        }
    }
}

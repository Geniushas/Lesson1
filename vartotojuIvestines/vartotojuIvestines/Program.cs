using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vartotojuIvestines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmasis vartotojau, iveskite savo skaiciu:");
            double vartotojasVienas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Antrasis vartotojau, iveskite savo skaiciu:");
            double vartotojasDu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sandauga: " + vartotojasVienas * vartotojasDu);
            Console.WriteLine("Dalyba: " + vartotojasVienas / vartotojasDu);
            Console.WriteLine("Suma: " + (vartotojasVienas + vartotojasDu));
            Console.WriteLine("Skirtumas: " + (vartotojasVienas - vartotojasDu));

            Console.ReadLine();
            
        }
    }
}

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
            double skaiciusVienas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Antrasis vartotojau, iveskite savo skaiciu:");
            double skaiciusDu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sandauga: " + skaiciusVienas * skaiciusDu);
            Console.WriteLine("Dalyba: " + skaiciusVienas / skaiciusDu);
            Console.WriteLine("Suma: " + (skaiciusVienas + skaiciusDu));
            Console.WriteLine("Skirtumas: " + (skaiciusVienas - skaiciusDu));

            Console.ReadLine();
            
        }
    }
}

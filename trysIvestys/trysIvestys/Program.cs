using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trysIvestys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris pasirinktus skaicius:");

            Console.Write("Pirmas skaicius: ");
            double skaiciusA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Antras skaicius: ");
            double skaiciusB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Trecias skaicius: ");
            double skaiciusC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("(" + skaiciusA + " + " + skaiciusB + ") * " + skaiciusC + " = " + (skaiciusA + skaiciusB) * skaiciusC);
            Console.WriteLine(skaiciusA + " * " + skaiciusC + " + " + skaiciusB + " * " + skaiciusC + " = " + (skaiciusA * skaiciusC + skaiciusB * skaiciusC));

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciuVidurkis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zemiau iveskite keturis pasirinktus skaicius:");

            Console.Write("Pirmas skaicius: ");
            double skaiciusVienas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Antras skaicius: ");
            double skaiciusDu = Convert.ToDouble(Console.ReadLine());

            Console.Write("Trecias skaicius: ");
            double skaiciusTrys = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ketvirtas skaicius: ");
            double skaiciusKeturi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Siu skaiciu vidurkis: " + (skaiciusVienas + skaiciusDu + skaiciusTrys + skaiciusKeturi) / 4);

            Console.ReadLine();
            
        }
    }
}

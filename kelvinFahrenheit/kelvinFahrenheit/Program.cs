using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelvinFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite laipsnius Celsijais: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            int kelvis = celsius + 273;
            int farenheit = celsius * 18 / 10 + 32;

            Console.WriteLine("kelvin = " + kelvis);
            Console.WriteLine("fahrenheit = " + farenheit);

            Console.ReadLine();
        }
    }
}

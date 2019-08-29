using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1CS
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int trim1, trim2, trim3, prom, p1, p2, p3;
            Console.WriteLine("Ingrese el total de ventas del primer trimestre del año 2018: ");
            Console.Write("$"); trim1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas del segundo trimestre del año 2018: ");
            Console.Write("$"); trim2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el total de ventas del tercer trimestre del año 2018: ");
            Console.Write("$"); trim3 = Convert.ToInt32(Console.ReadLine());
            prom = trim1 + trim2 + trim3;
            p1 = (trim1 * 100) / prom;
            p2 = (trim2 * 100) / prom;
            p3 = (trim3 * 100) / prom;
            Console.WriteLine("El total de ventas del primer trimestre es: ${0}, su promedio es: {1}%" , trim1, p1);
            Console.WriteLine("El total de ventas del segundo trimestre es: ${0}, su promedio es: {1}%" , trim2, p2);
            Console.WriteLine("El total de ventas del tercer trimestre es: ${0}, su promedio es: {1}%" , trim3, p3);
            Console.ReadKey();
        }
    }
}

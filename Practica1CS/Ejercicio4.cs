using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1CS
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número para calcular su raiz cuadrada: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("La raiz cuadrada de su número es: " + Math.Pow(num, 0.5));
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1CS
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            double num1, num2, suma, resta, multiplicación, división;
            Console.WriteLine("Ingrese el primer número(Puede ser decimal):");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());
            suma = num1 + num2;
            resta = num1 - num2;
            multiplicación = num1 * num2;
            división = num1 / num2;
            Console.WriteLine("");
            Console.WriteLine("{0:N1} más {1:N1} es = {2:N1}", num1, num2, suma);
            Console.WriteLine("{0:N1} menos {1:N1} es = {2:N1}", num1, num2, resta);
            Console.WriteLine("{0:N1} por {1:N1} es = {2:N1}", num1, num2, multiplicación);
            Console.WriteLine("{0:N1} entre {1:N1} es = {2:N1}", num1, num2, división);
            Console.ReadKey();

        }
    }
}
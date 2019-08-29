using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1CS
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            string nombre;
            double isss, renta, afp, sueldo, descuento;
            Console.WriteLine("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo: ");
            Console.Write("$"); sueldo = Convert.ToDouble(Console.ReadLine());
            isss = sueldo * 0.03;
            afp = sueldo * 0.0725;
            renta = (sueldo - isss - afp - 472) * 0.1 + 17.67;
            descuento = sueldo - isss - afp - renta;
            Console.WriteLine("");
            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine("Su sueldo es: $" + sueldo);
            Console.WriteLine("El descuento ISSS es: ${0:N}", isss);
            Console.WriteLine("El descuento de renta es: ${0:N}", renta);
            Console.WriteLine("El descuento de AFP es: ${0:N}", afp);
            Console.WriteLine("El sueldo que se le pagará al sr {0} es: ${1:N}", nombre, descuento);
            Console.ReadKey();

        }
    }
}

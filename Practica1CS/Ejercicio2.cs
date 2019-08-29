using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1CS
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombre ="Mario Edgardo Mendoza";
            string cargo = "Programador";
            string correo = "mario.mendoza2@catolica.edu.sv";
            string fechaCont = "17 de noviembre de 2018";
            int edad = 19;
            int sueldo = 250;

            Console.WriteLine("DATOS DE EMPLEADO");

            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su cargo es: " + cargo);
            Console.WriteLine("Su correo es: " + correo);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Fue contratado la fecha: " + fechaCont);
            Console.WriteLine("Su sueldo es: $" + sueldo);
            Console.ReadKey();
        }
    }
}
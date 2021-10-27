using System;

namespace Ejercicio_6_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero;

            Console.Write("Introduzca un número: ");
            numero = Convert.ToDecimal(Console.ReadLine());

            numero = (133 * numero) / 100;

            Console.WriteLine("El 133% del número introducido es: " + numero);
        }
    }
}

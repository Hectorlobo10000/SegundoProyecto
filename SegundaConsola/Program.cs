using System;
using Segunda.Libreria;

namespace SegundaConsola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ingrese primer numero: ");
            int primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese operador: ");
            string operador = Console.ReadLine();

            Console.WriteLine("Ingrese segundo numero: ");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            Fabrica.CrearOperacion(operador);
            
            Console.ReadKey();
        }
    }
}
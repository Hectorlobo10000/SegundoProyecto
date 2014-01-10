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

            OperacionFabrica fabrica = ConfiguracionFabrica.ObtenerFabrica();
            IOperaciones operacion = fabrica.CrearOperacion(operador);

            Console.WriteLine("El resultado es: " + operacion.Operar(primerNumero, segundoNumero));
            Console.ReadKey();
        }
    }
}
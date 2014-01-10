using System.Collections.Generic;

namespace Segunda.Libreria
{
    public class OperacionFabrica
    {
        private readonly Dictionary<string, IOperaciones> _operaciones;

        public OperacionFabrica(Dictionary<string, IOperaciones> operaciones)
        {
            _operaciones = operaciones;
        }

        public IOperaciones CrearOperacion(string operador)
        {
            return _operaciones[operador];
        }
    }
}
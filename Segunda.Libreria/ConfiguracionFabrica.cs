using System.Collections.Generic;

namespace Segunda.Libreria
{
    public class ConfiguracionFabrica
    {
        public static OperacionFabrica ObtenerFabrica()
        {
            return new OperacionFabrica(new Dictionary<string, IOperaciones>
            {
                {"+", new SumarNumeros()},
                {"-", new RestarNumeros()},
                {"*", new MultiplicarNumeros()},
                {"/", new DividirNumeros()},
            });
        }
    }
}
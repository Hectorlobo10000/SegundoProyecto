namespace Segunda.Libreria
{
    public class Fabrica
    {
        public static void CrearOperacion(string operador)
        {
            if (operador == "+")
            {
                var operacion = new SumarNumeros();
            }
            else if (operador == "-")
            {
                var operacion = new RestarNumeros();
            }
            else if (operador == "*")
            {
                var operacion = new MultiplicarNumeros();
            }
            else if (operador == "/")
            {
                var operacion = new DividirNumeros();
            }
        }
    }
}
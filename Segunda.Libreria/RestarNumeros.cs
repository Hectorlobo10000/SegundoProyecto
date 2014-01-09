namespace Segunda.Libreria
{
    public class RestarNumeros : IOperaciones 
    {
        public double Operar(int primerNumero, int segundoNumero)
        {
            return primerNumero - segundoNumero;
        }
    }
}
namespace Heranca_Ref_Metodo.Metodos
{
    public class Ref
    {
        public static void Inverter(ref int a,ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }
}
using System;

namespace Heranca_Ref_Metodo.Metodos
{
    public class Out
    {
        public static void SeparaMonomio(string monomio, out string literal, out string numerico)
        {
            int indicePotencia = monomio.IndexOf("^");
            literal = monomio.Substring(0,indicePotencia);
            numerico = monomio.Substring(indicePotencia + 1);
        }

    }
}
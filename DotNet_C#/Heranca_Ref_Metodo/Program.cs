using System;
using Heranca_Ref_Metodo.Heranca;
using Heranca_Ref_Metodo.Metodos;

namespace Heranca_Ref_Metodo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Herança
            int lado = 2;
            Triangulo_Equilatero triangulo = new Triangulo_Equilatero(lado);
            Console.WriteLine($"Triangulo de lado {lado}:");
            Console.WriteLine($"Perimetro: {triangulo.Perimetro()}");
            Console.WriteLine($"Area: {triangulo.Area()}");

            lado = 3;
            int h = 4;
            Tetraedo tetraedo = new Tetraedo(3,4);
            Console.WriteLine($"\nTetraedo de lado {lado} e altura {h}:");
            Console.WriteLine($"Perimetro: {tetraedo.Perimetro()}");
            Console.WriteLine($"Area: {tetraedo.Area()}");
            Console.WriteLine($"Volume: {tetraedo.Volume()}\n\n");

            //Ref
            int x = 1, y = 2;
            Console.WriteLine($"Troca dos valores x ({x}) e y ({y}) por referência:");
            Ref.Inverter(ref x, ref y);
            Console.WriteLine($"x: {x}\ny: {y}\n\n");

            //Out
            string monomio = "3x^4";
            Console.WriteLine($"Dividindo o monomio {monomio} :");
            Out.SeparaMonomio(monomio, out string literal, out string numerico);
            Console.WriteLine($"Literal: {literal}\nPotência: {numerico}");

        }
    }
}

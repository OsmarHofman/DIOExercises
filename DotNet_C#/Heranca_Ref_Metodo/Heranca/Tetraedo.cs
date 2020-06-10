using System;
namespace Heranca_Ref_Metodo.Heranca
{
    public class Tetraedo : Triangulo_Equilatero
    {
        private int h;
        public Tetraedo(int lado, int h) : base(lado)
        {
            this.h = h;
        }

        public static double Altura(int lado)
        {
            return (lado * Math.Sqrt(6))/3;
        }

        public override double Area(){
            return Math.Pow(lado,2) * Math.Sqrt(3);
        }

        public double Volume(){
            return (this.Area() * h)/3;
        }
    }
}
using System;

namespace Heranca_Ref_Metodo.Heranca
{
    public class Triangulo_Equilatero
    {
        protected int lado;

        public Triangulo_Equilatero(int lado){
            this.lado = lado;
        }

        public int Perimetro(){
            return lado * 3;
        }

        public virtual double Area(){
            return (Math.Pow(lado,2) * Math.Sqrt(3))/4;
        }
    }
}
using System;
using Exemplo_Pilha.Estrutura;

namespace Exemplo_Pilha
{
    class Programa
    {
        static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.Empilhar(1);
            pilha.Empilhar(2);
            pilha.Empilhar(3);
            Console.WriteLine(pilha.Desempilhar());
            Console.WriteLine(pilha.Desempilhar());
            Console.WriteLine(pilha.Desempilhar());

           //causa o throw 
           //Console.WriteLine(pilha.Desempilhar());
        }
    }
}

using System;

namespace Exemplo_Pilha.Estrutura
{
    public class Pilha
    {
        Posicao topo;

        public void Empilhar(object item)
        {
            topo = new Posicao(topo,item);
        }

        public object Desempilhar()
        {
            if(topo == null)
            {
                throw new InvalidOperationException("Não há elementos na pilha!");
            }

            object itemRetirado = topo.item;
            topo = topo.proximo;
            return itemRetirado;
        }

        class Posicao
        {
            public Posicao proximo;
            public object item;

            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}
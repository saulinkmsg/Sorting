namespace Sorting.basic_class.dynamic
{
    public class ListaDynamic
    {
        public CelulaLista? primeiro;
        public CelulaLista? ultimo;
        public int qtdeItens;
        public ListaDynamic()
        {

        }

        public ListaDynamic(int item)
        {
            this.primeiro = this.ultimo = new CelulaLista(item);
            qtdeItens++;
        }

        public bool InserirFim(int item)
        {
            return InserirPosicao(item, qtdeItens);
        }

        public bool InserirPosicao(int item, int posicao)
        {
            CelulaLista novoItem = new CelulaLista(item);
            if(posicao > qtdeItens)
            {
                Console.WriteLine("A posição requisitada é maior do que o tamanho da lista");
                return false;
            }

            if(primeiro == null)
            {
                primeiro = novoItem;
                ultimo = novoItem;
            }
            else
            {
                CelulaLista atual = primeiro;
                for(int i = 0; i < posicao - 1; i++)
                {
                    atual = atual.proximo;
                }
                CelulaLista seguinte = atual.proximo;
                atual.proximo = novoItem;
                novoItem.anterior = atual;
                novoItem.proximo = seguinte;
                if(seguinte != null)
                {
                    seguinte.anterior = novoItem;
                }               
            }
            qtdeItens++;
            return true;
        }

        public int RemoverPosicao(int posicao)
        {
            if (posicao >= qtdeItens)
            {
                Console.WriteLine("A posição requisitada é maior do que o tamanho da lista");
                return 0;
            }
            
            CelulaLista atual = primeiro;
            for (int i = 0; i < posicao; i++)
            {
                atual = atual.proximo;
            }

            if (atual.proximo != null)
            {
                atual.proximo.anterior = atual.anterior;
            }

            if (atual.anterior != null)
            {
                atual.anterior.proximo = atual.proximo;
            }

            if (primeiro == atual)
            {
                primeiro = atual.proximo;
            }

            if (ultimo == atual)
            {
                ultimo = atual.anterior;
            }

            qtdeItens--;
            return atual.valor;
        }

        public int AcessarValorNaPosicao(int posicao)
        {
            if (posicao >= qtdeItens)
            {
                Console.WriteLine("A posição requisitada é maior do que o tamanho da lista");
                return 0;
            }

            CelulaLista atual = primeiro;
            for (int i = 0; i < posicao; i++)
            {
                atual = atual.proximo;
            }
            return atual.valor;
        }

        public bool TrocarValorNaPosicao(int valor, int posicao)
        {
            if (posicao >= qtdeItens)
            {
                Console.WriteLine("A posição requisitada é maior do que o tamanho da lista");
                return false;
            }

            CelulaLista atual = primeiro;
            for (int i = 0; i < posicao; i++)
            {
                atual = atual.proximo;
            }
            atual.valor = valor;
            return true;
        }
    }
}

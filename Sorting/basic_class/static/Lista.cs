namespace Sorting.basic_class.@static
{
    class Lista
    {
        public int[] lista;
        public int cont;

        public Lista(int n)
        {
            lista = new int[n];
            cont = 0;
        }

        public bool InserirFim(int item)
        {
            if (cont < lista.Length)
            {
                lista[cont] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirInicio(int item)
        {
            if (cont < lista.Length)
            {
                for(int i = cont - 1; i >= 0; i++)
                {
                    lista[i + 1] = lista[i];
                }

                lista[0] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirPosicao(int item, int pos)
        {
            if (pos > cont)
            {
                Console.WriteLine("A posição requisitada é maior do que o tamanho da lista");
                return false;
            }

            if (cont < lista.Length)
            {
                for (int i = cont - 1; i >= pos; i++)
                {
                    lista[i + 1] = lista[i];
                }

                lista[pos] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public int RemoverFim()
        {
            if(cont > 0)
            {
                int item = lista[cont - 1];
                lista[cont - 1] = 0;
                cont--;
                return item;
            }
            else
            {
                Console.WriteLine("A lista está vazia");
                return 0;
            }
        }

        public int RemoverInicio()
        {
            if (cont > 0)
            {
                int item = lista[0];
                for(int i = 0; i < cont - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                lista[cont - 1] = 0;
                cont--;
                return item;
            }
            else
            {
                Console.WriteLine("A lista está vazia");
                return 0;
            }
        }

        public int RemoverPosicao(int pos)
        {
            if (cont > 0)
            {
                int item = lista[pos];
                for (int i = pos; i < cont - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                lista[cont - 1] = 0;
                cont--;
                return item;
            }
            else
            {
                Console.WriteLine("A lista está vazia");
                return 0;
            }
        }

    }
}

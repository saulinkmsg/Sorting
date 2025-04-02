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

        public bool Inserir(int item)
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



    }
}

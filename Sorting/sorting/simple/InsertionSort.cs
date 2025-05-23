using Sorting.basic_class.dynamic;

namespace Sorting.sorting.simple
{
    public static class InsertionSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] vet)
        {
            int j, x;
            int n = vet.Length;
            Atribuicoes++;
            for (int i = 1; i < n; i++)
            {
                Atribuicoes++;
                x = vet[i];
                Atribuicoes++;
                j = i - 1;
                Atribuicoes++;

                while (j >= 0 && vet[j] > x)
                {
                    Comparacoes++;
                    vet[j + 1] = vet[j];
                    Atribuicoes++;
                    j--;
                    Atribuicoes++;
                    Trocas++;
                }
                vet[j + 1] = x;
                Atribuicoes++;
            }
        }

        public static void Sort(ListaDynamic vet)
        {
            int j, x;
            int n = vet.qtdeItens;
            Atribuicoes++;
            for (int i = 1; i < n; i++)
            {
                Atribuicoes++;
                x = vet.AcessarValorNaPosicao(i);
                Atribuicoes++;
                j = i - 1;
                Atribuicoes++;

                while (j >= 0 && vet.AcessarValorNaPosicao(j) > x)
                {
                    Comparacoes++;
                    vet.TrocarValorNaPosicao(vet.AcessarValorNaPosicao(j), j + 1);
                    Atribuicoes++;
                    j--;
                    Atribuicoes++;
                    Trocas++;
                }
                vet.TrocarValorNaPosicao(x, j + 1);
                Atribuicoes++;
            }
        }
    }
}

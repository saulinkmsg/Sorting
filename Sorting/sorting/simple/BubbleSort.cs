namespace Sorting.sorting.simple
{
    public static class BubbleSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] vet)
        {
            int n = vet.Length;
            Atribuicoes++;

            for (int i = 0; i < n; i++)
            {
                Atribuicoes++;
                for (int j = n - 1; j > i; j--)
                {
                    Atribuicoes++;
                    Comparacoes++;
                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        Atribuicoes++;
                        vet[j] = vet[j - 1];
                        Atribuicoes++;
                        vet[j - 1] = tmp;
                        Atribuicoes++;
                        Trocas++;
                    }
                }
            }
        }
    }
}

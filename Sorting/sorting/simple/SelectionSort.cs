namespace Sorting.sorting.simple
{
    public static class SelectionSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] vet)
        {
            int n = vet.Length;
            Atribuicoes++;
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                Atribuicoes++;
                min = i;
                Atribuicoes++;
                for (int j = i + 1; j < n; j++)
                {
                    Atribuicoes++;
                    Comparacoes++;
                    if (vet[j] < vet[min])
                    {
                        min = j;
                        Atribuicoes++;
                    }
                }

                int tmp = vet[i];
                Atribuicoes++;
                vet[i] = vet[min];
                Atribuicoes++;
                vet[min] = tmp;
                Atribuicoes++;
                Trocas++;
            }
        }
    }
}

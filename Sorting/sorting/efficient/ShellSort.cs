namespace Sorting.sorting.efficient
{
    public static class ShellSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] array)
        {
            int n = array.Length;
            Atribuicoes++;

            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                Atribuicoes++;
                for (int i = gap; i < n; i++)
                {
                    Atribuicoes++;
                    int temp = array[i];
                    Atribuicoes++;
                    int j;
                    Atribuicoes++;

                    for (j = i; j >= gap; j -= gap)
                    {
                        Comparacoes++;
                        Atribuicoes++;
                        if (array[j - gap] > temp)
                        {
                            array[j] = array[j - gap];
                            Atribuicoes++;
                            Trocas++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    array[j] = temp;
                    Atribuicoes++;
                }
            }
        }
    }
}

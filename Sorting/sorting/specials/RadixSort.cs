namespace Sorting.sorting.specials
{
    public static class RadixSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] array)
        {
            int n = array.Length;
            Atribuicoes++;

            if (n == 0)
                return;

            int max = array[0];
            for (int i = 1; i < n; i++)
            {
                Comparacoes++;
                if (array[i] > max)
                {
                    max = array[i];
                    Atribuicoes++;
                }
            }

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(array, n, exp);
                Atribuicoes++;
            }
        }

        private static void CountSort(int[] array, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];
            Atribuicoes += n + 10;

            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
                Atribuicoes++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
                Atribuicoes++;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (array[i] / exp) % 10;
                output[count[digit] - 1] = array[i];
                count[digit]--;
                Atribuicoes += 3;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
                Atribuicoes++;
            }
        }
    }
}

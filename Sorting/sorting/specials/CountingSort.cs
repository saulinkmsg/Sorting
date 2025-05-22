namespace Sorting.sorting.specials
{
    public static class CountingSort
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

            int[] count = new int[max + 1];
            Atribuicoes++;

            for (int i = 0; i < n; i++)
            {
                count[array[i]]++;
                Atribuicoes++;
            }

            int index = 0;
            Atribuicoes++;
            for (int i = 0; i <= max; i++)
            {
                while (count[i]-- > 0)
                {
                    Comparacoes++;
                    array[index++] = i;
                    Atribuicoes++;
                }
            }
        }
    }
}

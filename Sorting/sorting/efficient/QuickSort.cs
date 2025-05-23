namespace Sorting.sorting.efficient
{
    public static class QuickSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] array)
        {
            QuickSortRecursive(array, 0, array.Length - 1);
            Atribuicoes++;
        }

        private static void QuickSortRecursive(int[] array, int low, int high)
        {
            Atribuicoes += 2;
            if (low < high)
            {
                Comparacoes++;
                int pi = Partition(array, low, high);
                Atribuicoes++;

                QuickSortRecursive(array, low, pi - 1);
                QuickSortRecursive(array, pi + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int mid = low + (high - low) / 2;
            Atribuicoes++;
            int pivotIndex = Mediana(array, low, mid, high);
            Atribuicoes++;

            int tempPivot = array[pivotIndex];
            array[pivotIndex] = array[high];
            array[high] = tempPivot;
            Atribuicoes += 3;
            Trocas++;

            int pivot = array[high];
            Atribuicoes++;
            int i = low - 1;
            Atribuicoes++;

            for (int j = low; j < high; j++)
            {
                Atribuicoes++;
                Comparacoes++;
                if (array[j] < pivot)
                {
                    i++;
                    Atribuicoes++;

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    Atribuicoes += 3;
                    Trocas++;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            Atribuicoes += 3;
            Trocas++;

            return i + 1;
        }

        private static int Mediana(int[] array, int a, int b, int c)
        {
            Comparacoes += 3;
            if (array[a] > array[b])
            {
                if (array[b] > array[c]) return b;
                else if (array[a] > array[c]) return c;
                else return a;
            }
            else
            {
                if (array[a] > array[c]) return a;
                else if (array[b] > array[c]) return c;
                else return b;
            }
        }
    }
}

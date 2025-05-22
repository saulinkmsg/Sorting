namespace Sorting.sorting.efficient
{
    public static class HeapSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] array)
        {
            int n = array.Length;
            Atribuicoes++;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Atribuicoes++;
                Heapify(array, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Atribuicoes++;
                int temp = array[0];
                Atribuicoes++;
                array[0] = array[i];
                Atribuicoes++;
                array[i] = temp;
                Atribuicoes++;
                Trocas++;

                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int heapSize, int rootIndex)
        {
            int largest = rootIndex;
            Atribuicoes++;
            int left = 2 * rootIndex + 1;
            Atribuicoes++;
            int right = 2 * rootIndex + 2;
            Atribuicoes++;

            if (left < heapSize)
            {
                Comparacoes++;
                if (array[left] > array[largest])
                {
                    largest = left;
                    Atribuicoes++;
                }
            }

            if (right < heapSize)
            {
                Comparacoes++;
                if (array[right] > array[largest])
                {
                    largest = right;
                    Atribuicoes++;
                }
            }

            if (largest != rootIndex)
            {
                int swap = array[rootIndex];
                Atribuicoes++;
                array[rootIndex] = array[largest];
                Atribuicoes++;
                array[largest] = swap;
                Atribuicoes++;
                Trocas++;

                Heapify(array, heapSize, largest);
            }
        }
    }
}

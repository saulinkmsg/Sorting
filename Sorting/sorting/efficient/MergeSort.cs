namespace Sorting.sorting.efficient
{
    public static class MergeSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            Atribuicoes++;
        }

        private static void Sort(int[] array, int left, int right)
        {
            Atribuicoes += 2;
            if (left < right)
            {
                Comparacoes++;
                int middle = left + (right - left) / 2;
                Atribuicoes++;

                Sort(array, left, middle);
                Sort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;
            Atribuicoes += 2;

            int[] L = new int[n1];
            int[] R = new int[n2];
            Atribuicoes += n1 + n2;

            for (int i = 0; i < n1; i++)
            {
                Atribuicoes++;
                L[i] = array[left + i];
            }

            for (int j = 0; j < n2; j++)
            {
                Atribuicoes++;
                R[j] = array[middle + 1 + j];
            }

            int iL = 0, iR = 0, k = left;
            Atribuicoes += 3;

            while (iL < n1 && iR < n2)
            {
                Comparacoes++;
                if (L[iL] <= R[iR])
                {
                    array[k++] = L[iL++];
                    Atribuicoes++;
                }
                else
                {
                    array[k++] = R[iR++];
                    Atribuicoes++;
                }
            }

            while (iL < n1)
            {
                Comparacoes++;
                array[k++] = L[iL++];
                Atribuicoes++;
            }

            while (iR < n2)
            {
                Comparacoes++;
                array[k++] = R[iR++];
                Atribuicoes++;
            }
        }
    }
}

using System.Collections.Generic;

namespace Sorting.sorting.specials
{
    public static class BucketSort
    {
        public static long Comparacoes = 0;
        public static long Atribuicoes = 0;
        public static long Trocas = 0;

        public static void Sort(int[] array)
        {
            int n = array.Length;
            Atribuicoes++;

            if (n <= 0)
                return;

            int max = array[0];
            Atribuicoes++;
            for (int i = 1; i < n; i++)
            {
                Comparacoes++;
                if (array[i] > max)
                {
                    max = array[i];
                    Atribuicoes++;
                }
            }

            int bucketCount = max / 10 + 1;
            Atribuicoes++;
            List<int>[] buckets = new List<int>[bucketCount];
            Atribuicoes++;

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
                Atribuicoes++;
            }

            foreach (int num in array)
            {
                Atribuicoes++;
                int index = num / 10;
                Atribuicoes++;
                buckets[index].Add(num);
                Atribuicoes++;
            }

            int k = 0;
            Atribuicoes++;
            foreach (List<int> bucket in buckets)
            {
                bucket.Sort();
                foreach (int num in bucket)
                {
                    array[k++] = num;
                    Atribuicoes++;
                }
            }
        }
    }
}

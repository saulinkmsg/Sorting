using Sorting.enums;
using Sorting.sorting.simple;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static void Ordenar(Sortings algoritmo, int[] vet)
        {

            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    BubbleSort.Sort(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    SelectionSort.Sort(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    InsertionSort.Sort(vet);
                    break;

                case Sortings.BUCKETSORT:
                    break;

                case Sortings.COUNTINGSORT:
                    break;

                case Sortings.RADIXSORT:
                    break;

                case Sortings.SHELLSORT:
                    break;

                case Sortings.QUICKSORT:
                    break;

                case Sortings.MERGESORT:
                    break;

                case Sortings.HEAPSORT:
                    break;
            }
        }
    }
}

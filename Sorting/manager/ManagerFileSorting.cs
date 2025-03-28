using Sorting.enums;
using Sorting.print;
using Sorting.sorting.simple;
using Sorting.utils;

namespace Sorting.manager
{
    class ManagerFileSorting
    {
        public static void Ordenar(Sortings algoritmo, int[] vet)
        {
            int[] ordenado = UtilClonar.Clonar(vet);

            PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, algoritmo);

            switch (algoritmo)
            {
                case Sortings.BUBBLESORT:
                    ordenado = BubbleSort.Sorting(vet);
                    break;

                case Sortings.SELECTIONSORT:
                    ordenado = SelectionSort.Sorting(vet);
                    break;

                case Sortings.INSERTIONSORT:
                    ordenado = InsertionSort.Sorting(vet);
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

            PrintSolutionStatic.ImprimirArrayMesmaLinha(ordenado, algoritmo);
        }
    }
}

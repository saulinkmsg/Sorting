using Sorting.manager;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git

        int[] vet = ManagerFileReader.Arquivo10TXT();

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);


        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.SELECTIONSORT, vet);


        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.INSERTIONSORT, vet);


        //vet = ManagerFileReader.Arquivo100TXT();

        //ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

    }
}
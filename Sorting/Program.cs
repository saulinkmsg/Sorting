using Sorting.manager;

public class Program
{
    public static void Main(string[] args)
    {

        int[] vet = ManagerFileReader.Arquivo10TXT();

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

    }



}
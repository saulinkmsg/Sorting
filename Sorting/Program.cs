using Sorting.basic_class.@static;
using Sorting.sorting.efficient;
using Sorting.sorting.simple;
using Sorting.sorting.specials;
using Sorting.utils;
using Sorting.manager;


public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776

        //int[] vet = ManagerFileReader.Arquivo10TXT();

        //PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);

        //ManagerFileSorting.Ordenar(Sorting.enums.Sortings.BUBBLESORT, vet);

        //PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.BUBBLESORT);


        // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado





        //Questao1();
        //Questao7();

    }

    public static void Questao1()
    {
        UtilCountingTime Cronometro = new UtilCountingTime();

        int[] arrayMilhaoItens;

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        HeapSort.Comparacoes = 0;
        HeapSort.Atribuicoes = 0;
        HeapSort.Trocas = 0;
        Cronometro.Init();
        HeapSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"HeapSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {HeapSort.Comparacoes}, Atribuicoes = {HeapSort.Atribuicoes}, Trocas = {HeapSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        MergeSort.Comparacoes = 0;
        MergeSort.Atribuicoes = 0;
        MergeSort.Trocas = 0;
        Cronometro.Init();
        MergeSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"MergeSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {MergeSort.Comparacoes}, Atribuicoes = {MergeSort.Atribuicoes}, Trocas = {MergeSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        QuickSort.Comparacoes = 0;
        QuickSort.Atribuicoes = 0;
        QuickSort.Trocas = 0;
        Cronometro.Init();
        QuickSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"QuickSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {QuickSort.Comparacoes}, Atribuicoes = {QuickSort.Atribuicoes}, Trocas = {QuickSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        ShellSort.Comparacoes = 0;
        ShellSort.Atribuicoes = 0;
        ShellSort.Trocas = 0;
        Cronometro.Init();
        ShellSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"ShellSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {ShellSort.Comparacoes}, Atribuicoes = {ShellSort.Atribuicoes}, Trocas = {ShellSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        BubbleSort.Comparacoes = 0;
        BubbleSort.Atribuicoes = 0;
        BubbleSort.Trocas = 0;
        Cronometro.Init();
        BubbleSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"BubbleSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {BubbleSort.Comparacoes}, Atribuicoes = {BubbleSort.Atribuicoes}, Trocas = {BubbleSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        InsertionSort.Comparacoes = 0;
        InsertionSort.Atribuicoes = 0;
        InsertionSort.Trocas = 0;
        Cronometro.Init();
        InsertionSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"InsertionSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {InsertionSort.Comparacoes}, Atribuicoes = {InsertionSort.Atribuicoes}, Trocas = {InsertionSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        SelectionSort.Comparacoes = 0;
        SelectionSort.Atribuicoes = 0;
        SelectionSort.Trocas = 0;
        Cronometro.Init();
        SelectionSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"SelectionSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {SelectionSort.Comparacoes}, Atribuicoes = {SelectionSort.Atribuicoes}, Trocas = {SelectionSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        BucketSort.Comparacoes = 0;
        BucketSort.Atribuicoes = 0;
        BucketSort.Trocas = 0;
        Cronometro.Init();
        BucketSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"BucketSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {BucketSort.Comparacoes}, Atribuicoes = {BucketSort.Atribuicoes}, Trocas = {BucketSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        CountingSort.Comparacoes = 0;
        CountingSort.Atribuicoes = 0;
        CountingSort.Trocas = 0;
        Cronometro.Init();
        CountingSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"CountingSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {CountingSort.Comparacoes}, Atribuicoes = {CountingSort.Atribuicoes}, Trocas = {CountingSort.Trocas}");

        arrayMilhaoItens = ManagerFileReader.Arquivo1000000TXT();
        RadixSort.Comparacoes = 0;
        RadixSort.Atribuicoes = 0;
        RadixSort.Trocas = 0;
        Cronometro.Init();
        RadixSort.Sort(arrayMilhaoItens);
        Cronometro.Stop();
        Console.WriteLine($"RadixSort: Tempo = {Cronometro.TimeElapsed()} ms, Comparacoes = {RadixSort.Comparacoes}, Atribuicoes = {RadixSort.Atribuicoes}, Trocas = {RadixSort.Trocas}");
    }

    public static void Questao7()
    {
        int[] arrayCemAleatorios;

        arrayCemAleatorios = ManagerFileReader.Arquivo100TXT();
        Fila f = new Fila(150);
        Pilha p = new Pilha(150);

        for(int i = 0; i < arrayCemAleatorios.Length; i++)
        {
            f.Inserir(arrayCemAleatorios[i]);
            p.Inserir(arrayCemAleatorios[i]);
        }

        f.Mostrar();
        p.Mostrar();

        f.Inserir(7);
        f.Inserir(18);
        f.Remover();
        f.Inserir(50);
        f.Remover();
        f.Remover();
        f.Remover();
        f.Inserir(71);
        f.Remover();
        f.Remover();
        f.Inserir(99);

        p.Inserir(7);
        p.Inserir(18);
        p.Remover();
        p.Inserir(50);
        p.Remover();
        p.Remover();
        p.Remover();
        p.Inserir(71);
        p.Remover();
        p.Remover();
        p.Inserir(99);

        f.Mostrar();
        p.Mostrar();
    }

}
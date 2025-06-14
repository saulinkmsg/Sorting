﻿namespace Sorting.basic_class.dynamic
{
    public class FilaDynamic
    {
        public CelulaFilaEPilha? primeiro;
        public CelulaFilaEPilha? ultimo;
        public FilaDynamic()
        {

        }

        public FilaDynamic(int item)
        {
            this.primeiro = this.ultimo = new CelulaFilaEPilha(item);
        }

        public bool Inserir(int item)
        {
            CelulaFilaEPilha novoItem = new CelulaFilaEPilha(item);
            if (ultimo != null)
            {
                ultimo.proximo = novoItem;
            }         
            ultimo = novoItem;  
            if(primeiro == null)
            {
                primeiro = ultimo;
            }
            return true;
        }

        public int Remover()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Não é possível remover da fila.");
                return 0;
            }

            CelulaFilaEPilha tmp = primeiro;
            primeiro = primeiro.proximo;

            return tmp.valor;
        }
    }
}

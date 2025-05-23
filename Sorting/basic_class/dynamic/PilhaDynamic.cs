namespace Sorting.basic_class.dynamic
{
    public class PilhaDynamic
    {
        public CelulaFilaEPilha? primeiro;
        public CelulaFilaEPilha? ultimo;
        public PilhaDynamic()
        {

        }

        public PilhaDynamic(int item)
        {
            this.primeiro = this.ultimo = new CelulaFilaEPilha(item);
        }

        public bool Inserir(int item)
        {
            CelulaFilaEPilha novoItem = new CelulaFilaEPilha(item);
            novoItem.proximo = primeiro;
            primeiro = novoItem;
            if(ultimo == null)
            {
                ultimo = primeiro;
            }
            return true;
        }

        public int Remover()
        {
            if (primeiro == null)
            {
                Console.WriteLine("Não é possível remover da pilha.");
                return 0;
            }

            CelulaFilaEPilha tmp = primeiro;
            primeiro = primeiro.proximo;

            return tmp.valor;
        }
    }
}

namespace Sorting.basic_class.dynamic
{
    public class CelulaLista
    {
        public int valor;
        public CelulaLista? proximo;
        public CelulaLista? anterior;

        public CelulaLista()
        {
            this.proximo = null;
            this.anterior = null;
        }

        public CelulaLista(int valor)
        {
            this.valor = valor;
            this.proximo = null;
            this.anterior = null;
        }
    }
}

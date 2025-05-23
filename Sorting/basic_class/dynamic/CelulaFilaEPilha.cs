namespace Sorting.basic_class.dynamic
{
    public class CelulaFilaEPilha
    {
        public int valor;
        public CelulaFilaEPilha? proximo;

        public CelulaFilaEPilha()
        {
            this.proximo = null;
        }

        public CelulaFilaEPilha(int valor)
        {
            this.valor = valor;
            this.proximo = null;
        }
    }
}

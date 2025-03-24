using Sorting.reader;
using Sorting.utils;

namespace Sorting.manager
{
    class ManagerFileReader
    {
        static ReaderFile reader = new ReaderFile();
        public static int[] Arquivo10TXT()
        {
            reader = new ReaderFile("./inputs/10-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo100TXT()
        {
            reader = new ReaderFile("100-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo1000TXT()
        {
            reader = new ReaderFile("1000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo10000TXT()
        {
            reader = new ReaderFile("10000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo100000TXT()
        {
            reader = new ReaderFile("100000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }

        public static int[] Arquivo1000000TXT()
        {
            reader = new ReaderFile("1000000-aleatorios.txt");

            return Conversor.ConvertArrayStringsToInts(reader.LerLinhaALinha());

        }
    }
}

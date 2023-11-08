using System;

namespace listaLinear
{
    public class Lista
    {
        private int[] array;
        private int n;

        public Lista(int tamanho = 6)
        {
            array = new int[tamanho];
            n = 0;
        }

        public void InserirInicio(int x)
        {
            if (n >= array.Length)
                throw new Exception("Erro");

            for (int i = n; i > 0; i--)
                array[i] = array[i - 1];

            array[0] = x;
            n++;
        }

        public void InserirFim(int x)
        {
            if (n >= array.Length)
                throw new Exception("Erro ao inserir, não há espaço disponível neste objeto!");

            array[n] = x;
            n++;
        }

        public void Inserir(int x, int pos)
        {
            if (n >= array.Length || pos < 0 || pos > n)
                throw new Exception("Erro ao inserir");

            for (int i = n; i > pos; i--)
                array[i] = array[i - 1];

            array[pos] = x;
            n++;
        }

        public int RemoverInicio()
        {
            if (n == 0)
                throw new Exception("Erro!");

            int resp = array[0];
            n--;

            for (int i = 0; i < resp; i++)
                array[i] = array[i + 1];

            return resp;
        }

        public int RemoverFim()
        {
            if (n == 0)
                throw new Exception("Erro");

            return array[--n];
        }

        public int Remover(int pos)
        {
            if (n == 0 || pos < 0 || pos >= n)
                throw new Exception("Erro");

            int resp = array[pos];
            n--;

            for (int i = pos; i < n; i++)
                array[i] = array[i + 1];

            return resp;
        }

        public void Mostrar()
        {
            Console.Write("[");
            for (int i = 0; i < n; i++)
                Console.Write(array[i] + (i == n - 1 ? "" : " "));
            Console.Write("]\n");
        }

        public int GetSize()
        {
            return array.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.InserirInicio(1);
            lista.InserirInicio(3);
            lista.InserirInicio(5);
            lista.InserirFim(9);
            lista.Inserir(4, 2);
            lista.Inserir(7, 2);

            lista.Mostrar();

            lista.RemoverInicio();
            lista.RemoverFim();
            lista.Remover(2);

            lista.Mostrar();
        }
    }
}

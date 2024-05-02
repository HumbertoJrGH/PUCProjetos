using System;

namespace FilaPilha
{
    class Pilha
    {
        private int[] Array;
        private int N;

        public Pilha(int tam = 3)
        {
            this.N = 0;
            this.Array = new int[tam];
        }

        public void Empilhar(int x)
        {
            if (this.N == this.Array.Length) throw new Exception("Erro, pilha cheia!");

            this.Array[this.N] = x;
            this.N++;
        }

        public int Desempilhar()
        {
            if (this.N <= 0) throw new Exception("Erro, pilha vazia!");
            this.N--;
            return this.Array[this.N];
        }


        public void Mostrar()
        {
            Console.WriteLine($"Tamanho da Pilha: {this.N}");
            Console.Write("[");
            for (int i = 0; i < this.N; i++)
                Console.Write(this.Array[i] + (i == this.N - 1 ? "" : ", "));
            Console.Write("]\n");
        }

        public static void Teste(Pilha p)
        {
            p.Empilhar(1);
            p.Mostrar();
            p.Empilhar(1);
            p.Mostrar();
            p.Empilhar(1);
            p.Mostrar();

            try
            {
                p.Empilhar(1);
                p.Mostrar();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

    }

    class Fila
    {
        private int[] Array;
        private int Head = 0, Tail = 0;

        public Fila(int tam)
        {
            this.Array = new int[tam];
        }

        public void Inserir(int x)
        {
            if ((this.Tail - this.Head) < this.Array.Length)
                this.Array[this.Tail % this.Array.Length] = x;
            else throw new Exception("Fila cheia!");
            this.Tail++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando");
            Pilha p = new();
            Pilha.Teste(p);

            Console.WriteLine($"Removeu: {p.Desempilhar()}");
        }
    }
}

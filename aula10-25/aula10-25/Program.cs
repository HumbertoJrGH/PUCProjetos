using System;

namespace aula10_25
{
    class Celula
    {
        public int elemento;
        public Celula prox;
        public Celula()
        {
            elemento = 0;
            prox = null;
        }

        public Celula(int x)
        {
            elemento = x;
            prox = null;
        }
    }
    class Pilha
    {
        private Celula topo;
        public Pilha()
        {
            topo = null;
        }
        public void Inserir(int x)
        {
            Celula temp = new Celula(x);
            temp.prox = topo;

            topo = temp;
            temp = null;
        }
        public int Remover()
        {
            if (topo == null) throw new Exception("Erro!");

            int elemento = topo.elemento;
            Celula tmp = topo;
            topo = topo.prox;
            tmp.prox = null;
            tmp = null;
            return elemento;
        }

        public void Mostrar()
        {
            Console.Write("[");
            for (Celula i = topo; i != null; i = i.prox)
                Console.Write(i.elemento + (i.prox == null ? "" : ", "));
            Console.Write("]\n");
        }

        public static void Teste()
        {
            Pilha p = new Pilha();
            p.Inserir(1);
            // p.Mostrar();
            p.Inserir(2);
            // p.Mostrar();
            p.Inserir(3);
            // p.Mostrar();
            p.Inserir(4);
            // p.Mostrar();

            Console.WriteLine(p.Somar(p.topo));

            p = p.Inverter(p);

            Console.WriteLine(p.Somar(p.topo));
        }
        public int Somar(Celula c)
        {
            if (c.prox == null)
                return c.elemento;
            else
                return c.elemento + Somar(c.prox);
        }

        public Pilha Inverter(Pilha p)
        {
            Pilha pout = new Pilha();

            // while (p.topo != null)
            while (p.topo != null)
            {
                // Console.WriteLine(p.topo.elemento);
                p.Mostrar();
                pout.Mostrar();
                pout.Inserir(p.Remover());
                Console.Write("\n");
            }

            p.Mostrar();
            pout.Mostrar();

            return pout;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pilha.Teste();
        }
    }
}

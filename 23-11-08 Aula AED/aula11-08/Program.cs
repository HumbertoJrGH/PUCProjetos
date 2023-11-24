using System;

namespace aula11_08
{
    class CelulaDupla
    {
        public int elemento;
        public CelulaDupla prox, ant;
        public CelulaDupla() : this(0) { }
        public CelulaDupla(int x)
        {
            this.elemento = x;
            this.prox = this.ant = null;
        }
    }

    class ListaDupla
    {
        private CelulaDupla primeiro, ultimo;
        public ListaDupla()
        {
            primeiro = new CelulaDupla();
            ultimo = primeiro;
        }

        public void InserirInicio(int x)
        {
            CelulaDupla tmp = new CelulaDupla(x);
            tmp.ant = primeiro;
            tmp.prox = primeiro.prox;
            primeiro.prox = tmp;
            if (primeiro == ultimo)
                ultimo = tmp;
            else
                tmp.prox.ant = tmp;
            tmp = null;
        }

        public void InserirFim(int x)
        {
            ultimo.prox = new CelulaDupla(x);
            ultimo.prox.ant = ultimo;
            ultimo = ultimo.prox;
        }
        public int RemoverInicio()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");

            CelulaDupla tmp = primeiro;
            primeiro = primeiro.prox;
            int elemento = primeiro.elemento;
            tmp.prox = primeiro.ant = null;
            tmp = null;
            return elemento;
        }

        public int RemoverFim()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");

            int elemento = ultimo.elemento;
            ultimo = ultimo.ant;
            ultimo.prox.ant = null;
            ultimo.prox = null;
            return elemento;
        }
        public int Tamanho()
        {
            CelulaDupla c = primeiro.prox;
            int count;

            for (count = 0; c != null; c = c.prox, count++) ;
            return count;
        }

        public void Inserir(int x, int pos)
        {
            int tamanho = Tamanho();
            if (pos < 0 || pos > tamanho)
                throw new Exception("Erro!");
            else if (pos == 0)
                this.InserirInicio(x);
            else if (pos == tamanho)
                this.InserirFim(x);
            else
            {
                CelulaDupla i = primeiro;
                for (int j = 0; j < pos; j++, i = i.prox) ;
                CelulaDupla tmp = new CelulaDupla(x);
                tmp.ant = i;
                tmp.prox = i.prox;
                tmp.ant.prox = tmp.prox.ant = tmp;
                tmp = i = null;
            }
        }
        public int Remover(int pos)
        {
            int elemento, tamanho = Tamanho();
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            else if (pos < 0 || pos >= tamanho)
                throw new Exception("Erro!");
            else if (pos == 0)
                elemento = RemoverInicio();
            else if (pos == tamanho - 1)
                elemento = RemoverFim();
            else
            {
                CelulaDupla i = primeiro.prox;
                for (int j = 0; j < pos; j++, i = i.prox) ;
                i.ant.prox = i.prox;
                i.prox.ant = i.ant;
                elemento = i.elemento;
                i.prox = i.ant = null;
                i = null;
            }
            return elemento;
        }
        public void Mostrar()
        {
            CelulaDupla c = primeiro.prox;

            Console.Write("[ ");
            while (c != null)
            {
                Console.Write($"{c.elemento} ");
                c = c.prox;
            }
            Console.WriteLine("]");
        }

        public CelulaDupla Buscar(int x)
        {
            for (CelulaDupla c = primeiro.prox; c != null; c = c.prox)
                if (c.elemento == x)
                    return c;

            throw new Exception("Erro");
        }

        public int ContarElementos()
        {
            return Tamanho();
        }
        public void Inverter()
        {
            CelulaDupla anterior = null;
            CelulaDupla atual = primeiro.prox;
            CelulaDupla proxima = null;

            while (atual != null)
            {
                atual.ant = proxima;
                proxima = atual.prox;
                atual.prox = anterior;
                anterior = atual;
                atual = proxima;
            }

            primeiro.prox = anterior;
        }

        public bool EstaVazia()
        {
            return primeiro.prox == null;
        }

        public static ListaDupla CriarDeArray(int[] elementos)
        {
            ListaDupla l = new ListaDupla();
            for (int i = 0; i < elementos.Length; i++)
                l.InserirFim(elementos[i]);

            return l;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ListaDupla l = new ListaDupla();

            try
            {
                l.Buscar(1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu erro, lista vazia");
            }
            l.InserirInicio(1);
            l.InserirInicio(2);
            l.InserirInicio(3);
            l.InserirFim(4);
            l.InserirFim(5);
            l.InserirFim(6);
            l.Mostrar();
            Console.WriteLine(l.Buscar(1).elemento);
            Console.WriteLine(l.ContarElementos());
            l.Inserir(7, 1);
            l.Mostrar();
            l.Remover(2);
            l.Mostrar();
            l.Inverter();
            l.Mostrar();

            int[] v = new int[] { 1, 2, 3 };
            ListaDupla l2 = ListaDupla.CriarDeArray(v);

            Console.Write("\nSegundo objeto\n");
            l2.Mostrar();
        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace aula11_01
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
        public Celula(int n)
        {
            this.elemento = n;
            this.prox = null;
        }
    }

    class CelulaDupla
    {
        public int elemento;

    }

    class Lista
    {
        private Celula primeiro, ultimo;

        public Lista()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public void InserirInicio(int x)
        {
            Celula tmp = new Celula(x);
            tmp.prox = primeiro.prox;
            primeiro.prox = tmp;
            if (primeiro == ultimo)
                ultimo = tmp;

            tmp = null;
        }
        public void InserirFim(int x)
        {
            ultimo.prox = new Celula(x);
            ultimo = ultimo.prox;
        }

        public int Tamanho()
        {
            int tamanho = 0;
            Celula c = primeiro.prox;
            while (c != null)
            {
                tamanho++;
                c = c.prox;
            }
            return tamanho;
        }

        public void Inserir(int x, int pos)
        {
            int tamanho = Tamanho();
            if (pos < 0 || pos > tamanho)
                throw new Exception("Erro!");
            else if (pos == 0)
                InserirInicio(x);
            else if (pos == tamanho)
                InserirFim(x);
            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos; j++, i = i.prox) ;
                Celula tmp = new Celula(x);
                tmp.prox = i.prox;
                i.prox = tmp;
                tmp = i = null;
            }
        }
        public int RemoverInicio()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            Celula tmp = primeiro;
            primeiro = primeiro.prox;
            int elemento = primeiro.elemento;
            tmp.prox = null;
            tmp = null;
            return elemento;
        }
        public int RemoverFim()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            Celula i;
            for (i = primeiro; i.prox != ultimo; i = i.prox) ;
            int elemento = ultimo.elemento;
            ultimo = i;
            i = ultimo.prox = null;
            return elemento;
        }
        public int Remover(int pos)
        {
            int elemento, tamanho = Tamanho();
            if (primeiro == ultimo || pos < 0 || pos >= tamanho)
                throw new Exception("Erro!");
            else if (pos == 0)
                elemento = RemoverInicio();
            else if (pos == tamanho - 1)
                elemento = RemoverFim();
            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos; j++, i = i.prox) ;
                Celula tmp = i.prox;
                elemento = tmp.elemento; i.prox = tmp.prox;
                tmp.prox = null; i = tmp = null;
            }
            return elemento;
        }
        public void Mostrar()
        {
            Celula c = this.primeiro;
            if (c.prox != null)
                c = c.prox;
            else c = null;

            Console.Write("[ ");
            while (c != null)
            {
                Console.Write(c.elemento + " ");
                c = c.prox;
            }
            Console.WriteLine("]");
        }

        public void RemoverSegundo()
        {
            if (primeiro.prox.prox != null)
                if (primeiro.prox.prox.prox != null)
                    primeiro.prox.prox = primeiro.prox.prox.prox;
                else primeiro.prox.prox = null;
            else throw new Exception("Erro! Nao existe osegundo elemento");
        }

        public int Contar()
        {
            Celula c = primeiro.prox;
            int contador = 0;

            while (c != null)
            {
                c = c.prox;
                contador++;
            }

            return contador;
        }

        public bool Buscar(int x)
        {
            Celula c = primeiro.prox;

            while (c != null)
                if (c.elemento == x)
                    return true;
                else c = c.prox;
            return false;
        }

        public void Limpar()
        {
            while (primeiro.prox != null)
            {
                Celula tmp = primeiro.prox.prox;
                primeiro.prox = tmp;
                tmp = null;
            }
        }

        public bool EstaVazia()
        {
            if (primeiro.prox != null)
                return true;
            else return false;

        }

        public int Get(int pos)
        {
            Celula c = primeiro.prox;
            int i = 0;
            while (c != null)
                if (i == pos)
                    return c.elemento;
                else
                {
                    c = c.prox;
                    i++;
                }

            return 0;
        }

        public void Inverter()
        {
            Celula anterior = null;
            Celula atual = primeiro.prox;
            Celula proxima = null;

            while (atual != null)
            {
                proxima = atual.prox;
                atual.prox = anterior;
                anterior = atual;
                atual = proxima;
            }

            primeiro.prox = anterior;
        }

        public int UltimoElemento(Celula c = null)
        {
            if (c == null) c = primeiro;
            if (c.prox == null)
                return c.elemento;
            else
                return this.UltimoElemento(c.prox);
        }

        public int SomaElementos(Celula c = null)
        {
            if (c == null) c = primeiro.prox;
            if (c.prox == null)
                return c.elemento;
            else
                return c.elemento + this.SomaElementos(c.prox);
        }

        public bool Existe(int x, Celula atual)
        {
            if (atual == null)
                return false;
            else if (atual.elemento == x)
                return true;
            else return this.Existe(x, atual.prox);
        }

        public void ImprimirRecursivo(Celula atual)
        {
            if (atual == null)
                Console.Write("");
            else
            {
                Console.Write($"{atual.elemento} ");
                this.ImprimirRecursivo(atual.prox);
            }
        }

        public void Teste()
        {
            if (this.Existe(2, primeiro.prox))
                Console.WriteLine("2 existe na lista");
            else
                Console.WriteLine("2 não existe na lista");

            if (this.Existe(7, primeiro.prox))
                Console.WriteLine("7 existe na lista");
            else
                Console.WriteLine("7 não existe na lista");

            this.ImprimirRecursivo(primeiro.prox);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            l.Mostrar();
            l.InserirInicio(7);
            l.InserirInicio(5);
            l.InserirInicio(3);
            l.Mostrar();
            l.InserirInicio(1);
            l.Mostrar();
            l.InserirFim(2);
            l.Mostrar();
            l.RemoverInicio();
            l.Mostrar();
            l.RemoverFim();
            l.Mostrar();
            l.Inserir(22, 1);
            l.Mostrar();
            l.Remover(0);
            l.Mostrar();
            Console.WriteLine($"A quantidade de itens é: {l.Contar()}");
            Console.WriteLine(l.Buscar(1) ? "Tem 1" : "Não tem 1");
            Console.WriteLine(l.Buscar(7) ? "Tem 7" : "Não tem 7");
            l.Mostrar();
            Console.WriteLine(l.Buscar(7) ? "Não está vazia" : "Está vazia");
            l.Limpar();
            l.Mostrar();
            Console.WriteLine(l.Buscar(7) ? "Não está vazia" : "Está vazia");
            l.InserirInicio(1);
            l.InserirInicio(2);
            l.InserirInicio(3);
            l.Mostrar();
            Console.WriteLine($"Item da primeira posição é {l.Get(0)}");
            Console.WriteLine($"Item da segunda posição é {l.Get(1)}");
            Console.WriteLine($"Item da terceira posição é {l.Get(2)}");
            l.Inverter();
            l.Mostrar();
            Console.WriteLine($"O último elemento é: {l.UltimoElemento()}");
            l.Inverter();
            l.Mostrar();
            Console.WriteLine($"O último elemento é: {l.UltimoElemento()}");
            Console.WriteLine($"A soma dos elementos é: {l.SomaElementos()}");
            l.Inverter();
            l.Mostrar();
            Console.WriteLine($"A soma dos elementos é: {l.SomaElementos()}");
            l.Inverter();
            l.Mostrar();
            Console.WriteLine($"A soma dos elementos é: {l.SomaElementos()}");
            l.Teste();
        }
    }
}

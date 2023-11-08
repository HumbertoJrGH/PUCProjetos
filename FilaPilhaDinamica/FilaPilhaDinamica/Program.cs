using System;
namespace FilaPilhaDinamica
{
	class Celula
	{
		public int elemento;
		public Celula prox;
		public Celula() : this(0) { }
		public Celula(int x)
		{
			this.elemento = x;
			this.prox = null;
		}
	}
	class Fila
	{
		private Celula primeiro, ultimo;
		public Fila()
		{
			primeiro = new Celula();
			ultimo = primeiro;
		}
		public void inserir(int x)
		{
			ultimo.prox = new Celula(x);
			ultimo = ultimo.prox;
		}
		public int remover()
		{
			if (primeiro == ultimo)
			{
				throw new Exception("Erro!");
			}
			Celula tmp = primeiro;
			primeiro = primeiro.prox;
			int elemento = primeiro.elemento;
			tmp.prox = null;
			tmp = null;
			return elemento;
		}
		public void mostrar()
		{
			Console.Write("[");
			for (Celula i = primeiro; i != null; i = i.prox)
				Console.Write(i.elemento + (i.prox == null ? "" : ", "));
			Console.WriteLine("]");
		}
		public int ContElementos()
		{
			int cont = 0;
			for (Celula i = primeiro; i != null; i = i.prox)
			{
				cont++;
			}
			return cont;
		}
		public double MediaElementos()
		{
			int soma = 0, cont = 0;
			if (primeiro == ultimo)
			{
				throw new Exception("Erro!");
			}
			for (Celula i = primeiro; i != null; i = i.prox)
			{
				soma += i.elemento;
				cont++;
			}
			return soma / cont;
		}
		public int RemoverElemeto(int elemento)
		{
			if (primeiro == ultimo)
			{
				throw new Exception("Erro!");
			}
			if (elemento == primeiro.elemento)
			{
				remover();
				return elemento;
			}
			Celula anterior = primeiro;
			Celula atual = primeiro.prox;
			while (atual != null)
			{
				if (atual.elemento == elemento)
				{
					anterior.prox = atual.prox;
					if (atual == ultimo)
					{
						ultimo = anterior;
					}
					return elemento;
				}
				anterior = atual;
				atual = atual.prox;
			}
			throw new Exception("Erro! Esse elemento não esta na fila!");
		}
		public static void teste()
		{
			Fila f = new Fila();
			f.mostrar();
			f.inserir(1);
			f.inserir(2);
			f.inserir(3);
			f.inserir(4);
			f.inserir(5);
			f.inserir(6);
			f.inserir(7);
			f.mostrar();
			Console.WriteLine("Quantidade de elementos presente na fila: " +
			f.ContElementos());
			Console.WriteLine("Média dos elementos presentes na fila: " + f.MediaElementos());
			f.RemoverElemeto(4);
			f.mostrar();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Fila.teste();
		}
	}
}
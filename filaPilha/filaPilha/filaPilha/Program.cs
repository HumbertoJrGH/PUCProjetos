using System;
using System.Linq;

namespace filaPilha
{
	class Pilha
	{
		private int[] array;
		private int n = 0;

		public Pilha()
		{
			this.array = new int[6];
		}

		public Pilha(int tamanho)
		{
			this.array = new int[tamanho];
		}

		public void Empilhar(int x)
		{
			if (n == array.Length) throw new Exception("Erro, pilha cheia!");

			this.array[n] = x;
			n++;
		}

		public int Desempilhar()
		{
			if (this.EhVazia()) throw new Exception("Erro, pilha vazia!");
			n--;
			return array[n];
		}

		public bool EhVazia()
		{
			return n <= 0;
		}

		public void Mostrar()
		{
			Console.WriteLine($"Tamanho da Pilha: {this.n}");
			Console.Write("[");
			for (int i = 0; i < n; i++)
				Console.Write(array[i] + (i == n - 1 ? "" : ", "));
			Console.Write("]\n");
		}

		public static void Teste()
		{
			Pilha pilha = new Pilha();

			pilha.Mostrar();
			pilha.Empilhar(1);
			pilha.Mostrar();
			pilha.Empilhar(2);
			pilha.Mostrar();
			pilha.Empilhar(3);
			pilha.Mostrar();
			pilha.Empilhar(4);
			pilha.Mostrar();
			pilha.Empilhar(5);
			pilha.Mostrar();
			pilha.Empilhar(6);
			pilha.Mostrar();

			try
			{
				pilha.Empilhar(7);
			}
			catch (Exception err)
			{
				Console.WriteLine(err);
			}

			pilha.Mostrar();
			pilha.Desempilhar();
			pilha.Mostrar();
			pilha.Desempilhar();
			pilha.Mostrar();
			pilha.Desempilhar();
			pilha.Mostrar();
			pilha.Desempilhar();
			pilha.Mostrar();
			pilha.Desempilhar();
			pilha.Mostrar();
			pilha.Desempilhar();
			pilha.Mostrar();

			try
			{
				pilha.Desempilhar();
			}
			catch (Exception err)
			{
				Console.WriteLine(err);
			}

			pilha.Mostrar();
		}
	}

	class Fila
	{
		private int[] array;
		private int head = 0, tail = 0;
		public Fila()
		{
			array = new int[6];
		}

		public Fila(int tamanho)
		{
			array = new int[tamanho];
		}
		public void Inserir(int x)
		{
			Console.WriteLine($"Inserindo {x} no índice {tail}");
			if (tail - head < array.Length)
				array[tail % array.Length] = x;
			else throw new Exception("Fila cheia");
			tail++;
		}

		public int Remover()
		{
			Console.WriteLine($"Removendo primeiro item da fila ({array[head % array.Length]})");
			if (head < tail)
				head++;
			else throw new Exception("A fila está vazia");
			return array[(head - 1) % array.Length];
		}
		public void Mostrar()
		{
			Console.WriteLine($"Início: {head}");
			Console.WriteLine($"Fim: {tail}");
			Console.Write("[");
			for (int i = head; i < tail; i++)
				Console.Write(array[i % array.Length] + (i == tail - 1 ? "" : ", "));
			Console.Write("]\n\n");
		}
		public static void teste()
		{
			Fila f = new Fila();
			f.Mostrar();
			f.Inserir(1);
			f.Mostrar();
			f.Inserir(2);
			f.Mostrar();
			f.Inserir(3);
			f.Mostrar();
			f.Inserir(4);
			f.Mostrar();
			f.Inserir(5);
			f.Mostrar();
			f.Inserir(6);
			f.Mostrar();

			try
			{
				f.Inserir(7);
				f.Mostrar();
			}
			catch (Exception erro)
			{
				Console.WriteLine(erro);
			}

			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();

			f.Inserir(7);
			f.Mostrar();
			f.Inserir(8);
			f.Mostrar();
			f.Inserir(9);
			f.Mostrar();

			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			
			f.Inserir(10);
			f.Mostrar();
			f.Inserir(11);
			f.Mostrar();
			f.Inserir(12);
			f.Mostrar();
			f.Inserir(13);
			f.Mostrar();
			
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();
			f.Remover();
			f.Mostrar();

			try
			{
				f.Remover();
				f.Mostrar();
			}
			catch (Exception erro)
			{
				Console.WriteLine(erro);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Teste com Pilha ↓");
			Pilha.Teste();
			Console.WriteLine("\nTeste com Fila ↓");
			Fila.teste();
		}
	}
}

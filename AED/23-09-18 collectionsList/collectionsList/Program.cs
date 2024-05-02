using System;
using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace collectionsList
{
	class Program
	{
		static void Main(string[] args)
		{
			Ex1();
			Ex2();
			Ex3();
			Ex4();
			Ex5();
			Ex6();
			Ex7();
			Ex8();
			Ex9();
		}

		static void Ex1()
		{
			ArrayList a = new ArrayList();
			Stack s = new Stack();
			Queue q = new Queue();

			Console.WriteLine("1º Exercício");

			for (int i = 0; i < 10; i++)
			{
				Console.Write($"Adicione o {i + 1}º número: ");
				int n = int.Parse(Console.ReadLine());
				s.Push(n);
				q.Enqueue(n);
				a.Add(n);
			}

			Console.WriteLine($"\nNúmeros gravados no array ↓");
			for (int i = 0; i < a.Count; i++)
				if (i == a.Count - 1)
					Console.Write(a[i]);
				else
					Console.Write($"{a[i]}, ");

			Console.WriteLine($"\nNúmeros gravados na pilha ↓");
			foreach (object x in s)
				Console.Write($"{x}, ");

			Console.WriteLine($"\nNúmeros gravados na fila ↓");
			foreach (object x in q)
				Console.Write($"{x}, ");

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}

		static void Ex2()
		{
			ArrayList a = new ArrayList();
			Stack s = new Stack();
			Queue q = new Queue();

			Console.WriteLine("2º Exercício");

			for (int i = 0; i < 10; i++)
			{
				Console.Write($"Adicione o {i + 1}º texto: ");
				string str = Console.ReadLine();

				s.Push(str); q.Enqueue(str); a.Add(str);
			}

			Console.WriteLine($"\nTextos gravados no array ↓");
			for (int i = 0; i < a.Count; i++)
				if (i == a.Count - 1)
					Console.Write(a[i]);
				else
					Console.Write($"{a[i]}, ");

			Console.WriteLine($"\nTextos gravados na pilha ↓");
			foreach (object x in s)
				Console.Write($"{x}, ");

			Console.WriteLine($"\nTextos gravados na fila ↓");
			foreach (object x in q)
				Console.Write($"{x}, ");

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}

		static void Ex3()
		{
			ArrayList a = new ArrayList();
			Stack s = new Stack();
			Queue q = new Queue();

			Console.WriteLine("3º Exercício");

			for (int i = 1; i < 50; i += 2)
			{
				a.Add(i); s.Push(i); q.Enqueue(i);
			}

			int z = 0;
			for (int i = 0; i < a.Count; i++)
				z += (int)a[i];
			Console.WriteLine($"Total do array: {z}");

			z = 0;
			foreach (object x in s)
				z += (int)x;
			Console.WriteLine($"Total do pilha: {z}");

			z = 0;
			foreach (object x in q)
				z += (int)x;
			Console.Write($"Total do fila: {z}");

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}

		static void Ex4()
		{
			ArrayList a = new ArrayList();
			Stack s = new Stack();
			Queue q = new Queue();

			Console.WriteLine("4º Exercício");

			int i = 0;
			for (i = 1; i <= 100; i++)
			{
				a.Add(i); s.Push(i); q.Enqueue(i);
			}

			i = 0;

			int SA = 0;
			int SS = 0;
			int SQ = 0;
			while (i < 100)
			{
				if ((int)a[i] % 2 == 0)
					SA += (int)a[i];

				int popped = (int)s.Pop();
				if (popped % 2 == 0)
					SS += popped;

				int dequeued = (int)q.Dequeue();

				if (dequeued % 2 == 0)
					SQ += dequeued;

				i++;
			}

			Console.WriteLine($"SOMA ARRAY LIST: {SA}");
			Console.WriteLine($"SOMA STACK: {SS}");
			Console.WriteLine($"SOMA QUEUE: {SQ}");

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}

		static void Ex5()
		{
			Console.WriteLine("\n5º Exercício");

			ArrayList a = new ArrayList();
			Stack s = new Stack();
			Queue q = new Queue();

			int i = 1;
			do
			{
				a.Add(i);
				s.Push(i);
				q.Enqueue(i);
				i++;
			} while (i <= 100);


			int soma = 0;
			foreach (int x in a)
				soma += x;
			Console.WriteLine($"SOMATÓRIA ARRAY LIST: {soma}");

			soma = 0;
			foreach (int x in s)
				soma += x;
			Console.WriteLine($"SOMATÓRIA STACK: {soma}");

			soma = 0;
			foreach (int x in q)
				soma += x;
			Console.WriteLine($"SOMATÓRIA QUEUE: {soma}");

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}

		static void Ex6()
		{
			Console.WriteLine("\n6º Exercício");

			ArrayList AL = new ArrayList();
			Queue Q = new Queue();
			Stack ST = new Stack();
			Stack auxST = new Stack();
			int contAL = 0, contQ = 0, contST = 0, n = 0;

			while (n <= 100)
			{
				AL.Add(n);
				Q.Enqueue(n);
				ST.Push(n);
				n++;
			}

			foreach (int i in AL)
				contAL += i;
			Console.WriteLine($"A soma dos elementos da ArrayList é: {contAL}");

			foreach (int x in Q)
				contQ += x;
			Console.WriteLine($"A soma dos elementos da Queue é: {contQ}");

			foreach (object y in ST)
				auxST.Push(y);

			foreach (int z in auxST)
				contST += z;
			Console.WriteLine($"A soma dos elementos da Stack é: {contST}");

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}


		public static ArrayList Apagar(int n, int n2, ArrayList AL)
		{
			ArrayList a = new ArrayList(AL.Count);
			foreach (int i in AL)
				if (i != n && i != n2)
					a.Add(i);

			return a;
		}


		static void Ex7()
		{
			Console.WriteLine("\n7º Exercício");

			ArrayList a = new ArrayList() { 5, 13, 19, 31, 3, 7, 11, 5, 57, 13, 5 };
			Queue q = new Queue();
			Stack ST = new Stack();
			Stack auxST = new Stack();

			a = Apagar(5, 13, a);
			Console.WriteLine("ARRAY LIST:");
			foreach (int i in a)
				Console.WriteLine(i);

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}

		static void Ex8()
		{
			Console.WriteLine("\n8º Exercício");

			ArrayList a = new ArrayList();
			Stack s = new Stack();
			Queue q = new Queue();

			Console.Write("Quantos números deseja iterar? ");
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.Write("\nDigite o número próximo número da lista: ");
				int x = int.Parse(Console.ReadLine());

				a.Add(x); s.Push(x); q.Enqueue(x);
			}

			int SA = 0;
			foreach (int i in a)
				SA += i;

			Console.WriteLine($"SOMA ARRAY LIST: {SA}");
			Console.WriteLine($"MÉDIA ARRAY LIST: {SA / a.Count}");

			int SS = 0;
			foreach (int i in s)
				SS += i;

			Console.WriteLine($"SOMA STACK: {SS}");
			Console.WriteLine($"MÉDIA STACK: {SS / s.Count}");

			int SQ = 0;
			foreach (int i in a)
				SQ += i;

			Console.WriteLine($"SOMA QUEUE: {SQ}");
			Console.WriteLine($"MÉDIA QUEUE: {SQ / q.Count}");

			Console.WriteLine("\nPressione para prosseguir...");
			Console.ReadKey();
		}

		static void Ex9()
		{
			Console.WriteLine("\n9º Exercício");

			ArrayList a = new ArrayList();
			Stack s = new Stack();
			Queue q = new Queue();

			int num, Nnum, soma = 0, mediaAri;
			Console.Write("Informe quantos números serão digirados: ");
			Nnum = int.Parse(Console.ReadLine());

			for (int i = 1; i <= Nnum; i += 1)
			{
				Console.WriteLine("Digite o " + i + "º número: ");
				num = int.Parse(Console.ReadLine());
				a.Add(num);
				q.Enqueue(num);
				s.Push(num);
			}

			soma = 0;
			foreach (int n in a)
				soma += n;
			mediaAri = soma / Nnum;
			Console.WriteLine("A soma dos números (ARRAY LIST) informados é: " + soma + " \nA Media Aritimetica é: " + mediaAri);

			soma = 0;
			foreach (int n in q)
				soma += n;
			mediaAri = soma / Nnum;
			Console.WriteLine("A soma dos números (QUEUE) informados é: " + soma + " \nA Media Aritimetica é: " + mediaAri);

			soma = 0;
			foreach (int n in s)
				soma += n;
			mediaAri = soma / Nnum;
			Console.WriteLine("A soma dos números (STACK) informados é: " + soma + " \nA Media Aritimetica é: " + mediaAri);

		}
	}
}

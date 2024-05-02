using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste com referência de objetos:");
            Console.WriteLine("Declarando V1 & V2");
            int[] V1, V2;

            V1 = new int[5];

            Console.WriteLine("Atribuindo valores à V1");
            for (int i = 0; i < 5; i++)
                V1[i] = i * i;

            Console.WriteLine("Atribuindo V2 igual à V1");
            V2 = V1;

            Console.WriteLine("Atribuindo primeiro valor de V1 como 666");
            V1[0] = 666;

            for (int i = 0; i < V1.Length; i++)
                Console.WriteLine(V1[i]);

            Console.Write("\n");

            for (int i = 0; i < V2.Length; i++)
                Console.WriteLine(V2[i]);
            Console.WriteLine("Mesmo alterando V1 após a atribuição V2 também se altera afinal ambos são referência para os mesmos dados.");
        }
    }
}

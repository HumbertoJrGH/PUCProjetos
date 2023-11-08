using System;

namespace aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha = "";

            do
            {
                linha = Console.ReadLine();

                if (linha != null)
                    if (int.Parse(linha) % 2 == 0)
                        Console.WriteLine("Par");
                    else
                        Console.WriteLine("Ímpar");
            }
            while (linha != null);
        }
    }
}

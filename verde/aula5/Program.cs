using System;
using System.Collections.Generic;

namespace InverterSequencia
{
    public class Program
    {
        public static void Main()
        {
            string entrada = "";

            do
            {
                entrada = Console.ReadLine();
                if (entrada != null)
                {
                    string sequenciaInvertida = InverterSequencia(entrada);
                    Console.WriteLine($"{sequenciaInvertida}");
                }
            } while (entrada != null);
        }

        public static string InverterSequencia(string sequencia)
        {
            Stack<int> pilha = new Stack<int>();

            // Dividindo a sequência pelos espaços e empilhando os números.
            foreach (var s in sequencia.Split(' '))
            {
                int numero;
                if (int.TryParse(s, out numero))
                {
                    pilha.Push(numero);
                }
            }

            // Desempilhando e construindo a sequência invertida.
            List<string> sequenciaInvertida = new List<string>();
            while (pilha.Count > 0)
            {
                sequenciaInvertida.Add(pilha.Pop().ToString());
            }

            return string.Join(' ', sequenciaInvertida);
        }
    }
}

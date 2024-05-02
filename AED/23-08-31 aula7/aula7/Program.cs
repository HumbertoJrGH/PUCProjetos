using System;
using System.Diagnostics;

namespace aula7
{
    class ContadorRegressivo
    {
        public static int Contagem(int n)
        {
            if (n == 1)
                return 1;
            return Contagem(n - 1);
        }
    }

    class SomadorDigitos
    {
        public static int Somar(int n)
        {
            if (n < 10)
                return n;
            return (n % 10) + Somar(n / 10);
        }
    }

    class ImpressorCadeia
    {
        public static void Imprimir(string s, int n)
        {
            if (n == (s.Length - 1))
                Console.WriteLine(s[^1]);
            else
            {
                Console.WriteLine(s[n]);
                Imprimir(s, n + 1);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContadorRegressivo.Contagem(5));

            int resultado = SomadorDigitos.Somar(1006);
            Console.WriteLine(resultado);

            string s = "Ai zé da manga";
            ImpressorCadeia.Imprimir(s, 0);
        }
    }
}

using System;

namespace exercicioClasses
{
    class Calculadora
    {
        private float vAtual;

        public Calculadora()
        {
            vAtual = 0;
        }

        private float ReceberValor() {
            return float.Parse(Console.ReadLine());
        }

        public void Somar(int x)
        {
            Console.Write(vAtual + " + ");
            vAtual += ReceberValor();

            Mostrar();
        }

        public void Mostrar()
        {
            Console.WriteLine(vAtual);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();

            Console.WriteLine("Bem vindo!");

            c.Mostrar();
            c.Somar(4);
            c.Somar(32);
            c.Somar(6);

        }
    }
}

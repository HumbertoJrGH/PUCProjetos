using System;
using System.Collections.Generic;

namespace exercicioClasses
{
    class Calculadora
    {
        private float vAtual;

        public Calculadora()
        {
            vAtual = 0;
            int input = 0;

            Console.WriteLine("Iniciando Calculadora\nSeja bem-vindo!\n");

            do
            {
                Console.Write("Escolha uma operação ↓\n1• Somar\n2• Mostrar Resultado\n0• Sair");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Somar();
                        break;
                    case 2:
                        Mostrar();
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Minimizando Calculadora");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente outra opção!");
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        private float ReceberValor()
        {
            return float.Parse(Console.ReadLine());
        }

        private void Somar()
        {
            Console.Write(vAtual + " + ");
            vAtual += ReceberValor();

            Mostrar();
        }

        private void Mostrar()
        {
            Console.WriteLine(vAtual);
        }
    }

    class IMC
    {
        public IMC()
        {
            int input = 0;

            Console.WriteLine("Iniciando sistema de cálculo de IMC\nSeja bem-vindo!\n");

            do
            {
                Console.Write("Escolha uma operação ↓\n1•");
                input = int.Parse(Console.ReadLine());
            } while (input != 0);
        }
    }

    class Paint
    {
        public Paint()
        {
            Console.WriteLine("Iniciando Paint#!\nSeja bem-vindo!\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c;
            IMC i;
            Paint p;
            // p = new();

            List<object> l = new();

            int input = 0;

            Console.WriteLine("Bem vindo ao gerenciador de programas!");
            do
            {
                Console.WriteLine("Escolha qual dos programas deseja executar:\n1• Calculadora\n2• IMC\n3• Paint\n\n0• Sair");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        c = new();
                        break;
                    case 2:
                        i = new();
                        break;
                }
                Console.Clear();
            } while (input != 0);

            Console.Write("FIM DO PROGRAMA!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Simulado
{
    class Program
    {
        static float GetFloat(string msg)
        {
            Console.Write(msg);
            return float.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1");
            Número n = new(GetFloat("Informe o primeiro número desejado: "), GetFloat("Informe o segundo número desejado: "));

            Console.WriteLine($"Soma de {n.Num1} e {n.Num2}");
            Console.WriteLine(n.Soma());

            Console.WriteLine($"Subtração de {n.Num1} e {n.Num2}");
            Console.WriteLine(n.Soma());

            Console.WriteLine($"Multiplicação de {n.Num1} e {n.Num2}");
            Console.WriteLine(n.Soma());

            Console.WriteLine($"Divisão de {n.Num1} e {n.Num2}");
            Console.WriteLine(n.Soma());

            Console.ReadKey();

            Console.WriteLine("Exercício 2");
            CVetor cv = new CVetor();

            Console.WriteLine("Exercício 3");

            List<Paciente> l = new List<Paciente>();
            Paciente p = new Paciente();

            for (int i = 0; i < 5; i++)
                l.Add(p.Cadastrar());
            Paciente.Listar(l);

            Console.WriteLine("Exercício 4");
            // RESPOSTA: O MÉTODO ESTÁTICO NÃO PRECISA DE OBJETO PARA SER INVOCADO
            Console.WriteLine("Resultado = {0}", ABC.Calcula(5));
            Console.ReadKey();

            Console.WriteLine("Exercício 5");
            List<Funcionário> FuncList = new();
            List<Professor> ProfList = new();

            while ((FuncList.Count + ProfList.Count) < 100)
            {
                Console.Clear();
                Console.WriteLine("Você deseja adicionar ou mostrar os profissionais?\n1 - Mostrar\n2 - Adicionar");
                int opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                {
                    foreach (Funcionário func in FuncList)
                        func.Mostrar();
                    foreach (Professor prof in ProfList)
                        prof.Mostrar();
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Qual o tipo do funcionário?\n1 - Administrativo\n2 - Professor");
                    opt = int.Parse(Console.ReadLine());
                    if (opt == 1)
                        FuncList.Add(new Funcionário());
                    else if (opt == 2)
                        ProfList.Add(new Professor());
                    else Console.WriteLine("Opção Inválida!");
                }
                else Console.WriteLine("Opção Inválida!");
                Console.ReadKey();
            }
        }
    }
    class ABC
    {
        public static double Calcula(int x)
        {
            if (x % 2 == 0)
                return x * 2;
            else
                return x / 3;
        }
    }
}

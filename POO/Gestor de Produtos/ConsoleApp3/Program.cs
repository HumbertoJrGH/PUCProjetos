using System;
using System.Collections.Generic;

namespace GestorProdutos
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Operações o = new Operações();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gerencie produtos, escolha uma opção:" +
                    "\n1 - Cadastrar" +
                    "\n2 - Remover" +
                    "\n3 - Listar" +
                    "\n4 - Buscar" +
                    "\n5 - Modificar Estoque" +
                    "\n0 - Sair");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                    Cadastrar();
                else if (x == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Remover produto");
                    Console.Write("Informe o ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    o.RemProduto(ID);
                    Console.Clear();
                    Console.WriteLine("Produto removido com sucesso");
                    Console.ReadKey();

                }
                else if (x == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Listar produtos cadastrados");
                    o.ListarProdutos();
                    Console.ReadKey();
                }
                else if (x == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Buscar Produto");
                    Console.Write("Informe o ID: ");
                    int ID = int.Parse(Console.ReadLine());

                }
                else if (x == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Modificar estoque");
                    Console.Write("Informe o ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Informe quanto do estoque modificar: ");
                    int estoque = int.Parse(Console.ReadLine());
                    o.ModificarEstoque(ID, estoque);
                    Console.Clear();
                    Console.WriteLine("Estoque atualizado com sucesso");
                    Console.ReadKey();
                }
                else if (x == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do programa");
                    break;
                }
            }

            void Cadastrar()
            {
                Console.Clear();
                Console.WriteLine("Cadastrar novo produto");
                bool valido = false;

                while (!valido)
                {
                    try
                    {
                        o.AddProduto(new Produto(GetInt("Digite o ID"), GetStr("Digite o Nome"), GetStr("Digite a Descrição"), GetDou("Digite o preço"), GetInt("Digite o estoque inicial")));

                        Console.Clear();
                        Console.WriteLine("Produto adicionado com sucesso");
                        Console.ReadKey();
                        valido = true;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.Write("Entrada Inválida!");
                        Console.Write("Deseja reinserir as informações? S/n: ");
                        string resposta = Console.ReadLine();
                        if (resposta != "S")
                        {
                            Console.Clear();
                            Console.WriteLine("Inserção de novo produto cancelada.");
                            valido = true;
                            Console.ReadKey();
                        }
                    }

                }
            }

            static int GetInt(string str)
            {
                Console.Clear();
                Console.Write(str + ": ");
                return int.Parse(Console.ReadLine());
            }
            static string GetStr(string str)
            {
                Console.Clear();
                Console.Write(str + ": ");
                return Console.ReadLine();
            }
            static double GetDou(string str)
            {
                Console.Clear();
                Console.Write(str + ": ");
                return double.Parse(Console.ReadLine());
            }
        }
    }
}

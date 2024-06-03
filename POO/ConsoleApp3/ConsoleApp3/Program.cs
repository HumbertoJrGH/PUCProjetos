using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class ListaProdutos
    {
        private List<Produto> Lista;
        public ListaProdutos()
        {
            Lista = new List<Produto>();
        }
        public void AddProduto(Produto produto)
        {
            Lista.Add(produto);
        }

        public void RemProduto(int Id)
        {
            foreach (Produto produto in Lista)
                if (produto.Id == Id)
                {
                    Lista.Remove(produto);
                    return;
                }
            Console.WriteLine("Nenhum produto encontrado");
        }

        public void ListarProdutos()
        {
            foreach(Produto produto in Lista)
                Console.WriteLine(produto.ToString());
        }

        public void ModificarEstoque(int ID, int estoque)
        {
            foreach (Produto produto in Lista)
                if (produto.Id == ID)
                {
                    produto.AtualizarEstoque(estoque);
                    return;
                }
            Console.WriteLine("Nenhum produto encontrado");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ListaProdutos lista = new ListaProdutos();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Cadastre novos produtos:" +
                    "\n1 - Cadastrar" +
                    "\n2 - Remover" +
                    "\n3 - Listar" +
                    "\n4 - Modificar Estoque" +
                    "\n5 - Sair");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Cadastrar novo produto");
                    lista.AddProduto(new Produto(GetInt("Digite o ID"),GetStr("Digite o Nome"), GetStr("Digite a Descrição"), GetDou("Digite o preço"), GetInt("Digite o estoque inicial")));
                    Console.Clear();
                    Console.WriteLine("Produto adicionado com sucesso");
                    Console.ReadKey();
                }
                else if (x == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Remover produto");
                    Console.Write("Informe o ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    lista.RemProduto(ID);
                    Console.Clear();
                    Console.WriteLine("Produto removido com sucesso");
                    Console.ReadKey();

                }
                else if (x == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Listar produtos cadastrados");
                    lista.ListarProdutos();
                    Console.ReadKey();
                }
                else if (x == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Modificar estoque");
                    Console.Write("Informe o ID: ");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Informe quanto do estoque modificar: ");
                    int estoque = int.Parse(Console.ReadLine());
                    lista.ModificarEstoque(ID, estoque);
                    Console.Clear();
                    Console.WriteLine("Estoque atualizado com sucesso");
                    Console.ReadKey();
                }
                else if (x == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Saindo do programa");
                    break;
                }
            }
        }

        public static int GetInt(string str)
        {
            Console.Clear();
            Console.Write(str + ": ");
            return int.Parse(Console.ReadLine());
        }
        public static string GetStr(string str)
        {
            Console.Clear();
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
        public static double GetDou(string str)
        {
            Console.Clear();
            Console.Write(str + ": ");
            return double.Parse(Console.ReadLine());
        }
    }
}

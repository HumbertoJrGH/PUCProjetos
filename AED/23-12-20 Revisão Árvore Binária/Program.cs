using System;

namespace ConsoleApp2
{
    using System;

    namespace Revisao
    {
        public class No
        {
            public int elemento;
            public No esq;
            public No dir;

            /* public No(int elemento) No esq = null
            {
                this.elemento = elemento;
            }*/

            public No(int elemento, No esq = null, No dir = null)
            {
                this.elemento = elemento;
                this.esq = esq;
                this.dir = dir;
            }
        }

        public class DesafioArvore
        {
            public No raiz;

            public DesafioArvore()
            {
                raiz = null;
            }

            public void Inserir(int elemento)
            {
                raiz = Inserir(elemento, raiz);
            }

            public No Inserir(int elemento, No n)
            {
                if (n == null)
                {
                    n = new No(elemento);
                }
                else if (elemento < n.elemento)
                {
                    n.esq = Inserir(elemento, n.esq);
                }
                else if (elemento > n.elemento)
                {
                    n.dir = Inserir(elemento, n.dir);
                }
                else
                {
                    throw new Exception("Erro");
                }
                return n;
            }

            public bool Pesquisar(int elemento, No n)
            {
                bool resposta = false;

                if (n == null)
                {
                    return false;
                }
                else if (elemento == n.elemento)
                {
                    return true;
                }
                else if (elemento < n.elemento)
                {
                    resposta = Pesquisar(elemento, n.esq);
                }
                else
                {
                    resposta = Pesquisar(elemento, n.dir);
                }
                return resposta;
            }
            public int Altura(No n)
            {
                int esquerdo = 0, direito = 0, resposta = 0;

                if (n != null)
                {
                    esquerdo = Altura(n.esq);
                    direito = Altura(n.dir);
                    resposta = 1 + Math.Max(esquerdo, direito);
                    return resposta;
                }
                else
                {
                    return 0;
                }
            }

            public void CaminharPre(No n)
            {
                if (n != null)
                {
                    Console.Write($"{n.elemento} ");
                    CaminharPre(n.esq);
                    CaminharPre(n.dir);
                }
            }

            public void CaminharCentral(No n)
            {
                if (n != null)
                {
                    CaminharCentral(n.esq);
                    Console.Write($"{n.elemento} ");
                    CaminharCentral(n.dir);
                }
            }

            public void CaminharPos(No n)
            {
                if (n != null)
                {
                    CaminharPos(n.esq);
                    CaminharPos(n.dir);
                    Console.Write($"{n.elemento} ");
                }
            }

            public int ContarElementos(No n)
            {
                int resposta = 0;
                if (n != null)
                {
                    resposta = 1 + ContarElementos(n.esq) + ContarElementos(n.dir);
                }
                return resposta;
            }

            public int SomarElementos(No n)
            {
                int resposta = 0;
                if (n != null)
                {
                    resposta = n.elemento + SomarElementos(n.esq) + SomarElementos(n.dir);
                }
                return resposta;
            }

            public void Mostrar()
            {
                No n = raiz;
                Mostrar(n);
            }

            public No Mostrar(No n)
            {
                if (n != null)
                {
                    Mostrar(n.esq);
                    Console.WriteLine($"Mostrando Elementos: {n.elemento}");
                    Mostrar(n.dir);
                }
                return n;
            }
        }

        class Program
        {

            public static void Menu()
            {
                DesafioArvore d = new DesafioArvore();

                int choice = 0;

                do
                {
                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("Bem vindo ao desafio árvore binária.");
                    Console.WriteLine("Escolha dentre as opções abaixo:");
                    Console.WriteLine("1 - Inserir elemento na árvore");
                    Console.WriteLine("2 - Pesquisar se um elemento existe na arvore");
                    Console.WriteLine("3 - Mostrar a altura da árvore");
                    Console.WriteLine("4 - Mostrar os elementos contidos na arvore");
                    Console.WriteLine("5 - Sair do programa");

                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("Informe o elemento a ser inserido:");
                        int elemento = int.Parse(Console.ReadLine());
                        d.Inserir(elemento);
                        Console.WriteLine($"O elemento {elemento} foi inserido na arvore");
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Informe o elemento a ser pesquisado:");
                        int elemento = int.Parse(Console.ReadLine());
                        bool resposta = false;
                        resposta = d.Pesquisar(elemento, d.raiz);
                        if (resposta == false)
                            Console.WriteLine($"O elemento {elemento} não existe na arvore");
                        else
                            Console.WriteLine($"O elemento {elemento} existe na arvore");
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Altura da arvore:");

                        if (d.raiz == null)
                            Console.WriteLine("Arvore vazia");
                        else
                            Console.WriteLine(d.Altura(d.raiz));

                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("Elementos contidos na arvore:");
                        if (d.raiz == null)
                            Console.WriteLine("Não ha nenhum elemento na arvore");
                        else
                            d.CaminharCentral(d.raiz);
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Fim do Programa");
                    }
                } while (choice != 5);

            }
            public static void Main()
            {
                DesafioArvore d = new DesafioArvore();

                Menu();

            }
        }
    }
}

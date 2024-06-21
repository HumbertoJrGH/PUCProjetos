using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProdutos
{
    class Operações
    {
        private List<Produto> Lista;
        private Consulta xml;
        public Operações()
        {
            xml = new Consulta();
            Lista = new List<Produto>();
        }
        public void AddProduto(Produto produto)
        {
            xml.Add(produto.RetornarXMLProduto());
        }

        public void RemProduto(int ID)
        {
            xml.Remover(ID);
        }

        public void ListarProdutos()
        {
            xml.Mostrar();
        }

        public void BuscarProduto(int ID)
        {
            xml.Buscar(ID);
        }

        public void Modificar()
        {
            Console.WriteLine("Informe o ID para buscar o produto");
            Console.Write("ID: ");
            int ID = int.Parse(Console.ReadLine());
            bool existe = xml.Buscar(ID);

            if (existe)
            {
                Console.WriteLine("Qual informação deseja alterar deste produto?" +
                    "\n1 - Nome" +
                    "\n2 - Descrição" +
                    "\n3 - Preço" +
                    "\n4 - Estoque");

                int opt = 1;
            }
            else Console.WriteLine("Produto não existe!");
            Console.ReadKey();
        }
    }
}

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
            xml.Mostrar();
        }

        public void BuscarProduto(int ID)
        {
            xml.Buscar(ID);
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
}

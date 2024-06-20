using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestorProdutos
{
    internal class Produto
    {
        // Atributos privados para encapsulamento
        private int id;
        private string nome;
        private string descrição;
        private double preço;
        private int quantidadeEstoque;

        // Propriedades públicas para acessar e modificar os atributos
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Descrição { get { return descrição; } set { descrição = value; } }
        public double Preço { get { return preço; } set { preço = value; } }
        public int QuantidadeEstoque { get { return quantidadeEstoque; } set { quantidadeEstoque = value; } }

        // Construtor para inicializar o objeto Produto
        public Produto(int id, string nome, string descricao, double preco, int quantidadeEstoque)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descrição = descricao;
            this.Preço = preco;
            this.QuantidadeEstoque = quantidadeEstoque;
        }

        // Método para verificar se o produto está em estoque
        public bool EstaEmEstoque(int quantidadeDesejada)
        {
            return QuantidadeEstoque >= quantidadeDesejada;
        }

        // Método para atualizar a quantidade do produto no estoque
        public void AtualizarEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        // Método para imprimir as informações do produto
        public override string ToString()
        {
            return $"ID: {Id}\nNome: {Nome}\nDescrição: {Descrição}\nPreço: {Preço:F2}\nQuantidade em Estoque: {QuantidadeEstoque}";
        }

        public XElement RetornarXMLProduto()
        {
            return new XElement("Produto",
                new XElement("ID", this.id),
                new XElement("Nome", this.nome),
                new XElement("Descrição", this.descrição),
                new XElement("Preço", this.preço),
                new XElement("Estoque", this.quantidadeEstoque)
                );
        }
    }
}

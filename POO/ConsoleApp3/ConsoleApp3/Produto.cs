using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorProdutos
{
    internal class Produto
    {
        // Atributos privados para encapsulamento
        private int id;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidadeEstoque;

        // Propriedades públicas para acessar e modificar os atributos
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public double Preco { get { return preco; } set { preco = value; } }
        public int QuantidadeEstoque { get { return quantidadeEstoque; } set { quantidadeEstoque = value; } }

        // Construtor para inicializar o objeto Produto
        public Produto(int id, string nome, string descricao, double preco, int quantidadeEstoque)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
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
            return $"ID: {Id}\nNome: {Nome}\nDescrição: {Descricao}\nPreço: {Preco:F2}\nQuantidade em Estoque: {QuantidadeEstoque}";
        }
    }
}

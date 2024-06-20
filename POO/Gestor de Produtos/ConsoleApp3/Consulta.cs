using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace GestorProdutos
{
    class Consulta
    {
        XElement XML;
        public Consulta()
        {
            XElement Raiz;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.xml");

            try
            {
                if (!File.Exists(path))
                {
                    Raiz = new XElement("Root");
                    Raiz.Save(path);
                    Console.WriteLine("Arquivo base não encontrado, criado um novo.");
                }
                else
                {
                    Raiz = XElement.Load(path);
                    Console.WriteLine("XML carregado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}, criando base de dados na memória.");
                Raiz = new XElement("Root");
            }

            this.XML = Raiz;
        }

        internal void Add(XElement xElement)
        {
            try
            {
                this.XML.Add(xElement);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível adicionar o produto requisitado");
            }
        }

        internal void Mostrar()
        {
            var consulta = from p in XML.Elements("Produto")
                           select new
                           {
                               id = (string)p.Element("ID"),
                               nome = (string)p.Element("Nome"),
                               descrição = (string)p.Element("Descrição"),
                               preço = (string)p.Element("Preço"),
                               estoque = (string)p.Element("Estoque")
                           };

            Console.WriteLine($"{consulta.Count()} índices encontrados.");
            foreach (var x in consulta)
            {
                Console.WriteLine($"{x.id}: {x.nome} - {x.descrição}" +
                    $"\n{x.preço} - {x.estoque}\n");
            }

        }
    }
}

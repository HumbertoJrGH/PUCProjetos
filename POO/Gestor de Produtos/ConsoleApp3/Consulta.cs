using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace GestorProdutos
{
    class Consulta
    {
        XElement XML;
        string xmlPath;
        public Consulta()
        {
            XElement Raiz;
            xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.xml");

            try
            {
                if (!File.Exists(xmlPath))
                {
                    Raiz = new XElement("Root");
                    Raiz.Save(xmlPath);
                    Console.WriteLine("Arquivo base não encontrado, criado um novo.");
                }
                else
                {
                    Raiz = XElement.Load(xmlPath);
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
                XML.Add(xElement);
                XML.Save(xmlPath);
                Console.WriteLine("Sucesso ao inserir produto.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível adicionar o produto requisitado.");
            }
        }

        internal void Mostrar()
        {
            this.XML = XElement.Load(xmlPath);
            var consulta = from p in XML.Elements("Produto")
                           select new Produto((int)p.Element("ID"), (string)p.Element("Nome"), (string)p.Element("Descrição"), (double)p.Element("Preço"), (int)p.Element("Estoque"));

            Console.WriteLine($"{consulta.Count()} índices encontrados.");
            foreach (var p in consulta) Console.WriteLine(p + "\n");
        }

        internal bool Buscar(int ID)
        {
            var Consulta = from p in XML.Elements("Produto")
                           where ((int)p.Element("ID")).Equals(ID)
                           select new Produto((int)p.Element("ID"), (string)p.Element("Nome"), (string)p.Element("Descrição"), (double)p.Element("Preço"), (int)p.Element("Estoque"));

            if (Consulta.Any())
            {
                Console.WriteLine("Produto encontrado:");
                Console.WriteLine(Consulta);

                foreach (var x in Consulta) Console.WriteLine(x + "\n");
                return true;
            }
            else Console.WriteLine("Produto não encontrado");
            return false;
        }

        internal void Remover(int ID)
        {
            XML = XElement.Load(xmlPath);
            try
            {
                IEnumerable<XElement> Consulta = (IEnumerable<XElement>)(from E in XML.Elements("Produto")
                                                                         where ((int)E.Element("ID")).Equals(ID)
                                                                         select E);
                Console.WriteLine($"Consulta retornou {Consulta.Count()} índices");
                if (Consulta.Any())
                {
                    foreach (XElement x in Consulta)
                        x.Element("ID").Parent.Remove();
                    XML.Save(xmlPath);
                    Console.WriteLine($"Sucesso ao remover produto do ID: {ID}");
                }
                else Console.WriteLine("Produto não encontrado!");
                Console.ReadKey();
            }
            catch (Exception E)
            {
                Console.Clear();
                Console.WriteLine("Erro ao tentar excluir produto:");
                Console.WriteLine(E.Message);
                Console.ReadKey();
            }
        }
    }
}

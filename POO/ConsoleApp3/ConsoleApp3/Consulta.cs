using System;
using System.IO;
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
    }
}

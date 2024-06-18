using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace aplicaçãoJSON
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

            var Consulta = from p in Raiz.Elements("Aluno")
                           select new
                           {
                               Nome = (string)p.Element("Nome"),
                               Mail = (string)p.Element("Mail"),
                               Telefone = (string)p.Element("TelCel"),
                           };
            Console.Clear();

            Console.WriteLine(Consulta.ToArray().Length);
            foreach (var x in Consulta)
            {
                Console.WriteLine("{0} - Telefone: {1}", x.Nome, x.Telefone);
                Console.WriteLine("Mail: {0}\n", x.Mail);
            }


            Console.ReadKey();
            Console.WriteLine("Fim do programa.");
            Console.ReadKey();

        }
    }
}

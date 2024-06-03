using System;
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
            XElement Raiz = XElement.Load("C:\\Users\\humbe\\source\\repos\\aplicaçãoJSON\\aplicaçãoJSON\\dados.xml");

            var Consulta = from p in Raiz.Elements("Aluno")
                           select new
                           {
                               Nome = (string)p.Element("Nome"),
                               Mail = (string)p.Element("Mail"),
                               Telefone = (string)p.Element("TelCel"),
                           };
            Console.Clear();

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

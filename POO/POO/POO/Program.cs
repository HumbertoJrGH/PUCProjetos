using System;

namespace POO
{
    public class Profissional
    {
        private string Nome;
        private string CPF;
        private string DataAdmissão;
        private string Salário;

        public void LerProfissional()
        {

        }

        protected void MostrarProfissional()
        {
            Console.WriteLine($"{this.Nome} - {this.CPF}");
            Console.WriteLine($"{this.DataAdmissão}");
            Console.WriteLine($"{this.Salário:F2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    public class Paciente
    {
        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }
        private string _DataNascimento;
        public string DataNascimento
        {
            get { return _DataNascimento; }
            set { _DataNascimento = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public Paciente Cadastrar()
        {
            Console.Write("Digite o nome do paciente: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Digite o telefone do paciente: ");
            this.Telefone = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Digite a data de nascimento do paciente: ");
            this.DataNascimento = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Digite o e-mail do paciente: ");
            this.Email = Console.ReadLine();
            Console.WriteLine("");

            return this;
        }

        public static void Listar(List<Paciente> l)
        {
            int i = 0;
            foreach(Paciente p in l)
            {
                Console.WriteLine($"Paciente {i}: {p.Nome} {p.Telefone} {p.DataNascimento} {p.Email}");            
                i++;
            }
        }
    }
}

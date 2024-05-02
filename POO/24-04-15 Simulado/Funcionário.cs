using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    class Funcionário
    {
        protected string Nome;
        protected string Endereço;
        protected string Telefone;
        protected string CPTS;
        protected float Salário;

        public Funcionário()
        {
            Console.Write("Favor digite o Nome do Funcionário: ");
            this.Nome = getString();
            Console.Write("Favor digite o Endereço do Funcionário: ");
            this.Endereço = getString();
            Console.Write("Favor digite o Telefone do Funcionário: ");
            this.Telefone = getString();
            Console.Write("Favor digite o Número da CPTS do Funcionário: ");
            this.CPTS = getString();
            Console.Write("Favor digite o Salário do Funcionário: ");
            this.Salário = getFloat();
        }

        public void Mostrar()
        {
            Console.WriteLine($"{this.Nome} \n{this.Endereço} \n{this.Telefone} \n{this.CPTS} \n{this.Salário}");
        }

        protected string getString()
        {
            return Console.ReadLine();
        }
        protected float getFloat()
        {
            return float.Parse(Console.ReadLine());
        }
    }
}

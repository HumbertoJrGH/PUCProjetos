using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    class Professor : Funcionário
    {
        private string Especialização;
        public Professor() : base()
        {
            Console.Write("Favor digite a Especialização do Professor: ");
            this.Especialização = base.getString();
        }
        public void Mostrar()
        {
            Console.WriteLine($"{this.Nome} \n{this.Endereço} \n{this.Telefone} \n{this.CPTS} \n{this.Salário} \n{this.Especialização}");
        }
    }
}

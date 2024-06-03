using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Médico : Profissional
    {
        private string CRM { get; set; }
        private string Especialidade { get; set; }

        public void LerMédico()
        {
            base.LerProfissional();
            Console.Write("CRM: ");
            this.CRM = Console.ReadLine();
            Console.Write("Especialidade: ");
            this.Especialidade = Console.ReadLine();

        }

        public void MostrarMédico()
        {
            base.MostrarProfissional();
        }
    }
}

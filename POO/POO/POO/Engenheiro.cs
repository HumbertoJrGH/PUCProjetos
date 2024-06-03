using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Engenheiro:Profissional
    {
        private string CREA { get; set; }
        private string Área { get; set; }

        public Engenheiro()
        {
            CREA = "";
            Área = "";
        }

        public void LerEngenheiro()
        {

        }
    }
}

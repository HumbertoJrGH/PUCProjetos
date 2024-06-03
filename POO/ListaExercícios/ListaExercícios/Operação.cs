using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercícios
{
    internal class Operação
    {
        ExecutaOperação op;
        public Operação(ExecutaOperação op)
        {
            this.op = op;
        }

        public void Execute(string s)
        {
            Console.WriteLine(op.Execute(s));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    class CVetor
    {
        int[] v;
        public CVetor(int n)
        {
            v = new int[n];
        }
        public CVetor()
        {
            Console.Write("Favor informe o tamanho desejado para o vetor: ");
            v = new int[int.Parse(Console.ReadLine())];
        }
    }
}

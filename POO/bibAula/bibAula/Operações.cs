using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibAula
{
    public class Operações
    {
        public static int[] CriaVetor(int Size, bool Randomize)
        {
            int[] Result = new int[Size];

            if (Randomize)
            {
                Random x = new Random();

                for (int i = 0; i < Size; i++)
                {
                    Result[i] = x.Next(LimInf);
                }
            }

            return Result;
        }

        public static void Mostra(double[] V)
        {
            Console.WriteLine("");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado
{
    public class Número
    {
        public float Num1 { get; set; }
        public float Num2 { get; set; }

        public Número(float Num1, float Num2)
        {
            if (Num1 < 0)
                this.Num1 = 0;
            else
                this.Num1 = Num1;

            if (Num2 < 0)
                this.Num2 = 0;
            else
                this.Num2 = Num1;
        }

        public float Soma()
        {
            return Num1 + Num2;
        }

        public float Subtração()
        {
            return Num1 - Num2;
        }

        public float Multiplicação()
        {
            return Num1 * Num2;
        }

        public float Divisão()
        {
            return Num1 / Num2;
        }
    }
}

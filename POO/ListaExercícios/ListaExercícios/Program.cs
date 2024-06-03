using System;

namespace ListaExercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operação OM = new(new Maiuscula());
            Operação Om = new(new Minuscula());

            OM.Execute("Hello World!");
            Om.Execute("Hello World!");
        }
    }
}

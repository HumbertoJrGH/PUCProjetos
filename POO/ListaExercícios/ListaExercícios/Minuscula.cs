﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercícios
{
    internal class Minuscula: ExecutaOperação
    {
        public override string Execute(string s)
        {
            string saida = "";
            for (int i = 0; i < s.Length; i++)
                saida += s[i].ToString().ToLower();
            return saida;
        }
    }
}

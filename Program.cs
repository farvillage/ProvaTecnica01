﻿//QUESTAO 01:

using System;

namespace MyProgram
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine(SOMA);
        }
    }
}

//RESULTADO DA SOMA: 91
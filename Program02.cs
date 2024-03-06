//QUESTAO 02:

using System;

namespace MyProgram
{
    public static class Program02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (Fibonnaci(numero))
            {
                Console.WriteLine($"{numero} pertence a Fibonnaci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence a Fibonnaci.");
            }
        }

        public static bool Fibonnaci(int numero)
        {
            int a = 0;
            int b = 1;

            while (b <= numero)
            {
                if (b == numero)
                {
                    return true;
                }

                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}
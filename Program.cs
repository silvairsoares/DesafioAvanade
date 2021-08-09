using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long x;
            long y;
            long numerosImpressos = 0;

            Console.Write("Informe um número para controle das quebras de linha 'X': ");
            x = long.Parse(Console.ReadLine());

            //Validação 1
            //(1 < X < 20) 
            if (x < 1 || x > 20)
            {
                Console.Write("Número controlador das quebras de linha deve estar entre 1 e 20");
                return;
            }

            //complete o código com sua solução
            Console.WriteLine("Informe um número, para que o programa escreva de 1 até este número 'Y': ");
            y = long.Parse(Console.ReadLine());

            //Validação 2
            //(X < Y < 100000).
            if (x > y || y > 100000)
            {
                Console.WriteLine("O número armazenado em Y deve ser maior que X e menor que 100000");
                return;
            }

            Console.Clear();

            for (int i = 1; i < y + 1; i++)
            {
                if (numerosImpressos >= x)
                {
                    Console.Write("\n");
                    numerosImpressos = 0;
                }
                if (i == y + 1) return;

                Console.Write(i + " ");
                numerosImpressos += 1;
            }
        }
    }
}

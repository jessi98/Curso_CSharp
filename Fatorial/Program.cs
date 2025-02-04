﻿namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            char resp;
            bool mostrar = false;

            Console.Write("Digite um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();//pula linha

            Console.WriteLine("Deseja mostrar os cálculos? (s/n)");
            resp = Convert.ToChar(Console.ReadLine().ToLower());//ToLower se colocar a letra maiuscula
            Console.WriteLine();

            if (resp == 's')
            {
                mostrar = true;
            }
            Console.WriteLine(fatorial(num, mostrar));
        }

        static int fatorial(int n, bool show = false)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                if (show)
                {
                    Console.Write(i);
                    if (i < n)
                    {
                        Console.Write(" x ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }
                }

                f *= i;

            }
            return f;
        }
    }
}

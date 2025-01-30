namespace Formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54821;
            double num2 = 54781.65874;

            Console.WriteLine($"{num1:f2}");// f para quantidade de casas depois da virgula
            Console.WriteLine($"{num2:n2}");// n coloca valores em milhares
            Console.WriteLine($"{num1:c2}");// c transforma valores em "R$" de acordo com a configuração de local do windows
            Console.WriteLine($"{num2:e2}");// e notação cientifca ex: e exponencial
            Console.WriteLine($"{num2:p2}");// p transforma valores em percentual

        }
    }
}

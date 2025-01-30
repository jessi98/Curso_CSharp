namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===========");
            Console.WriteLine("Calculadora");
            Console.WriteLine("===========");
            Console.WriteLine();

            Console.WriteLine("Digite um número: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite mais um número: ");
            double b = Convert.ToDouble(Console.ReadLine());

            soma(a, b);
            subtracao(a, b);
            multiplicacao(a, b);
            divisao(a, b);

        }

        static void soma(double a, double b)
        {
            double resultsoma = a + b;
            Console.WriteLine("A soma de " + a + " + " + b + " = " + resultsoma);
        }
        static void subtracao(double a, double b)
        {
            double resultsub = a - b;
            Console.WriteLine("A subtração de " + a + " - " + b + " = " + resultsub);
        }
        static void multiplicacao(double a, double b)
        {
            double resultmult = a * b;
            Console.WriteLine("A multiplicação de " + a + " x " + b + " = " + resultmult);
        }
        static void divisao(double a, double b)
        {
            double resultdiv = a / b;
            Console.WriteLine("A divisão de " + a + " / " + b + " = " + resultdiv);
        }
    }
}


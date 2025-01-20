namespace _009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double numero;

            Console.WriteLine("Digite o número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O núemro é par!");
            }
            else 
            {
                Console.WriteLine("O número é ímpar!");
            }
        }
    }
}

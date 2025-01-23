namespace Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mult;

            Console.Write("Digite o número para calcular a tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i ++) 
            {
                mult = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, mult);
            }

        }
    }
}

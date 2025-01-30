namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Calcular a área do triângulo");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("Digite o valor da base do triângulo em metros: ");
            double ba = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o valor da altura do triângulo em metros: ");
            double al = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            areaTriangulo(ba, al);
        }

        static void areaTriangulo (double ba, double al)
        {
            double a = (ba * al) / 2;
            Console.WriteLine($"A área do triângulo de {ba} x {al} é de {a:f2}m²");
        }
    }
}

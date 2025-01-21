namespace Ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                double distancia_km, preco1, preco2;
                Console.WriteLine("Digite os KM: ");
                distancia_km = Convert.ToDouble(Console.ReadLine());

                preco1 = 0.50;
                preco2 = 0.45;
                if (distancia_km <= 200)
                {
                    Console.WriteLine("A sua distancia foi: {0}km. O valor da passagem é: R${1}", distancia_km, preco1 * distancia_km);
                }
                else
                {
                    Console.WriteLine("A sua distancia foi: {0}km. O valor da passagem é: R${1}", distancia_km, preco2 * distancia_km);
                }
            }
        }
    }
}

namespace Ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Manga", "Lichia", "Banana", "Kiwi", "Limão", "Maça", "Uva", "Abacaxi", "Morango", "Abacate" };
            double[] valores = { 5.50, 12.90, 7.99, 16.50, 3.10, 7.20, 9.60, 6.30, 12.50, 5.80 };

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("A fruta " + frutas[i] + " custa R$ " + valores[i]);
            }

            Console.WriteLine();

            string fruta_maior = frutas.Max();
            string fruta_menor = frutas.Min();

            Console.WriteLine("A primeira fruta em ordem alfabetica é: " + fruta_menor);
            Console.WriteLine("A ultima fruta em ordem alfabetica é: " + fruta_maior);

            Console.WriteLine();

            double valor_maior = valores.Max();
            double valor_menor = valores.Min();

            Console.WriteLine("O menor preço é: R$ " + valor_menor);
            Console.WriteLine("O maior preço é: R$ " + valor_maior);
        }
    }
}

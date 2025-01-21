namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double salario;

            Console.Write("Digite o valor do seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());


            if (salario > 2500)
            {
                Console.WriteLine("O seu salário atual é de: {0}. E o aumento do seu salário é de 5%, o valor total é: {1} ", salario, ((salario * 0.05) + salario));
            }
            else if (salario > 1250)
            {
                Console.WriteLine("O seu salário atual é de: {0}. E o aumento do seu salário é de 10%, o valor total é: {1}", salario, ((salario * 0.1) + salario));
            }
            else 
            {
                Console.WriteLine("O seu salário atual é de: {0}. E o aumento do seu salário é de 15%, o valor total é: {1}", salario, ((salario * 0.15) + salario));
            }

        }
    }
}

using System;

namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double velocidade, valor_multa;
            string multa;


            Console.WriteLine("Digite a velocidade do carro");
            velocidade = Convert.ToDouble(Console.ReadLine());

            valor_multa = (velocidade - 80) * 7;

            if (velocidade > 80)
            {
                Console.WriteLine("Você foi multado! O valor a ser pago é: R${0}", valor_multa);
            }
            else
            {
                Console.WriteLine("Automovel não ultrapassou o limite!");
            }


        }
    }
}

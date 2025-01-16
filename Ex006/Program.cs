using System.Net.Http.Headers;

namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, MediaAluno;

            Console.WriteLine("Digite a primeira nota: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digiete a segunda nota: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            MediaAluno = (num1 + num2) / 2;

            Console.WriteLine("A média é: " + MediaAluno);

            //Usando Double para conversão do número
            
            //double n1, n2, MediaAluno;

            //Console.WriteLine("Digite a primeira nota: ");
            //n1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digiete a segunda nota: ");
            //n2 = Convert.ToDouble(Console.ReadLine());

            //MediaAluno = (n1 + n2) / 2;

            //Console.WriteLine("A média é: {0} ", MediaAluno);

            //Usando Perse para conversão do número

            //Console.WriteLine("Digite a nota do aluno: ");
            //float nota1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a segunda nota: ");
            //float nota2 = float.Parse(Console.ReadLine());

            //float media = (nota1 + nota2) / 2;

            //Console.WriteLine($"A média do aluno é: {media:F1}");
        }
    }
}

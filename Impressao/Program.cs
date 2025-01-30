using System;

namespace Impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Jéssica Batista dos Santos");
            Console.WriteLine();
            escreva("Curso C#");
            Console.WriteLine();
            escreva("Olá");
            Console.WriteLine();
        }
        //Escreva o texto centralizado em uma linha com o caracter informado

        static void escreva(string texto)
        {
            char caracter = '='; //caracter que será impresso
            int tamanho = texto.Length + 4; //Length para tamanho da linha
            string linha = new string(caracter, tamanho); //Cria uma linha com o caracter informado
            string textoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); //Centraliza o texto
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }
    }
}

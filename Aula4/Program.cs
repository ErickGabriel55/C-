using System;

/* Essa aula fala como receber informações do usuário através do console */
namespace ConsoleApp1.Aula4{
    class Program
    {

        static void Main(String[] args)
        {
            // Para receber algo do usuário usamos o Console.ReadLine() e colocamos em uma varável
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Seu nome é: {nome}");
            // Console.WriteLine(nome);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulasnamespace ConsoleApp1.Aula12.aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula sobre switch
            // Usado quando se tem muitas condições
            String cor = "Azul";
            switch(cor) {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo!");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é azul!");
                    break;
            }
    }
}

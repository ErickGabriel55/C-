using System;

/* Essa aula fala sobre os operadores aritméticos */
namespace Aula5{
    class Program
    {

        static void Main(String[] args)
        {
            int numeroEx = 20 + 20 - 80;
            int numeroMult = 10 * 90;
            float numeroDiv = 5.0f / 2; // Caso esteja dividindo algo e tenha pelo menos um numero decimal o resultado sempre será float
            // int numeroDiv = 90 / 10;


            // A ordem de precedência tbm importa no C#
            int test = 2 + 2 * 10; // Fará primeiro a multiplicação 
            int test2 = (2 + 2) * 10; // Fará primeiro os parenteses

            Console.WriteLine(numeroEx);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);
            Console.WriteLine(test);
            Console.WriteLine(test2);
        }

    }
}

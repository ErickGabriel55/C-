using System;
using System.Globalization;

/* Essa aula fala sobre os operadores aritméticos */
namespace first{
    class Program
    {

        static void Main(String[] args)
        {
            Console.Write("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            Console.Write("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            Console.Write("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

            float resultado = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A média entre as notas {nota1}, {nota2}, {nota3} foi {resultado}!");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace aula2
{
    class Program
{
        static void Main(string[] args)
        {
            // int: -156 como 32334
            // float: -156.5 32334.56 ==> Double | Decimal.
            // Bool: true ou false.
            // String: "Texto".
            // Char: 'a' o caracter deve ser em aspas simples.


            // tipo, nome, dado, ponto e vírgula.
            int segundaGuerra = 1939;
            String corFavorita = "Azul";
            float VelocidadeF1 = 294.48f;
            bool segundaGuerraAconteceu = true;
            var meuTexto = "Hello World - Erick Gabriel - Feliz natal";

            Console.WriteLine(meuTexto); // Escreve algo na tela
            Console.WriteLine(segundaGuerra); // Escreve algo na tela
            Console.WriteLine(corFavorita); // Escreve algo na tela
            Console.WriteLine(VelocidadeF1); // Escreve algo na tela
            Console.WriteLine(segundaGuerraAconteceu); // Escreve algo na tela
            
            VelocidadeF1 = 348.29f;
            Console.WriteLine($"Variável modificada {VelocidadeF1}");
        }
    }
}
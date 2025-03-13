using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace Aula8
{
    class Program
{
    // O USUÁRIO PRECISA DIGITAR A IDADE DELE NO CONSOLE;
    // COM BASE NA IDADE DESCOBRIREMOS SE ELE É UMA CRIANÇA, ADOLESCENTE, ADULTO OU IDOSO
    // É CRIANÇA ATÉ "12" ANOS
    // É ADOLESCENTE ATÉ "18" ANOS
    // É ADULTO ATÉ "44" ANOS
    // É IDOSO ATÉ "74" ANOS
        static void Main(string[] args){
            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            // Console.WriteLine(idade);
            if (idade <= 12){
                Console.Write("Você é uma criança!");
                
            }
            else if(idade > 12 && idade <= 18){
                Console.Write("Você é um adolescente!");
            }
            else if(idade > 18 && idade <= 44){
                Console.Write("Você é um adulto!");
            }
            else{
                Console.Write("Você é um idoso!");
            }
        }
    }
}

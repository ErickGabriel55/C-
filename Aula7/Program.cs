// OPERADORES LÓGICOS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace Aula7
{
    // && (e/and) e || (ou/or)
    // No && as duas condições precisam ser verdaddeiras
    // No || uma das condições precisam ser verdadeiras
    class Program
{
        static void Main(string[] args){
            int a = 10;
            int b = 20;
            int c = 200;

            if(a < b || a > c){ //SE
                Console.WriteLine("É verdade!");
            }
            else if(a > c){
                Console.WriteLine("Executou o ElseIf!");
            }
            else{ //SE NÃo
                Console.WriteLine("É mentira!");
            } 
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace aula1
{
    class Program
{
        public static int SolveMeFirst(int a, int b){
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Write("Qual o primeiro número? ");
            int numero1 = Int32.Parse(Console.ReadLine());
            Console.Write("Qual o segundo número? ");
            int numero2 = Int32.Parse(Console.ReadLine());
            Console.Write(SolveMeFirst(numero1, numero2));


        }
    }
}

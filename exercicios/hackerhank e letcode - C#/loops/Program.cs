/*def ao_quadrado(n):
    contador = 0
    while contador < n:
        print(f"{contador * contador}")
        contador += 1

numero = 5
ao_quadrado(numero)*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace loops
{
    class Program
{
        public static void ao_quadrado(int n){
            int contador = 0;
            while (contador < n){
                Console.WriteLine($"{contador * contador}");
                contador++;
            }

        }
        public static void Main(string[] args)
        {
            int numero = 5;
            ao_quadrado(numero);
        }
    }
}

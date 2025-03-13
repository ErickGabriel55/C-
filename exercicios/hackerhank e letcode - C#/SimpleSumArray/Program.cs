using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace SimpleSumArray
{
    class Program
{
        public static String SimpleSumArray(int[] array){
            int acumulador = array.Sum();
            int tamanho = array.Length;
            return $"{tamanho}\n{acumulador}";

        }
        static void Main(string[] args)
        {
            int[] numeros = new int[6] {1, 2, 3, 4, 10, 11};
            Console.WriteLine($"{numeros[0]}, {numeros[1]}");
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------------------------------------------------------");
            String resultado = SimpleSumArray(numeros);
            Console.WriteLine($"{resultado}");
        }
    }
}

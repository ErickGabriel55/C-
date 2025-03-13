using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace Aula9{
    class Program{
        static void Main(string[] args){
            /*GerarPreco(60);
            GerarPreco(-20);*/
            int soma1 = Somar(50, 80, 78);
            Console.WriteLine(soma1);

        }
    
        static void ExibirMsg(){
            Console.WriteLine("Que que eu to fazendo da minha vida");
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem vindo");
            Console.WriteLine("cru cru cru cruuuu");
            Console.WriteLine("valha");
        }

        static void GerarPreco(int preco){
            int precoAbs = Math.Abs(preco);
            int valorFinal = preco + (2 * precoAbs);
            Console.WriteLine("Valor Final: " + valorFinal);
        } 

    static int Somar(int a, int b, int c){
        int resultadoFinal = a + b + c;
        return resultadoFinal;
    }




    }
}

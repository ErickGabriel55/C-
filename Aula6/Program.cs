using System;

/* Essa aula fala sobre os condicionais */
namespace Aula6{
    class Program
    {
        int a = 10;
        int b = 20;
        int c = 2;
        static void Main(String[] args){
            if(a < b){ //SE
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
    

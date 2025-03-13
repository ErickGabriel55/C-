using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace aula1
{
    class Program
{
        static void Main(string[] args)
        {
            string[] produtos = new string[5] {"Dragon z kakarot", "Injustice 2", "Dragon ball: Sparking Zero", "Minecraft", "Genshin Impact"};

            Console.WriteLine(produtos[0]);
            Console.WriteLine(produtos[1]);
            Console.WriteLine(produtos[4]);
            Console.WriteLine(produtos[4][1]);
            
            Console.ReadLine();
        }
    }
}

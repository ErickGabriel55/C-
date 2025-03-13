using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    class Program
    {
        enum Cor {Azul, Verde, Amarelo, Vermelho }

        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Azul;
            Cor corFavoritaDaCarla = Cor.Vermelho;
            // int colorNumber = int.Parse(corFavorita);

            Console.WriteLine((Cor)2);
            Console.WriteLine(corFavoritaDaCarla);

            Console.ReadLine();
        }
    }
}

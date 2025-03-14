using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14{
    internal class Program{

        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
        static void Main(string[] args){
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1- Criar\n2- Deletar\n3- Editar\n4- Listar\n5- Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            // Console.WriteLine(opcaoSelecionada);
            switch (opcaoSelecionada){
            case Opcao.Criar:
                   Console.WriteLine("Vc quer cirar algo!");
                    break;
            case Opcao.Deletar:
                    Console.WriteLine("Hakai!");
                    break;
            case Opcao.Editar:
                    Console.WriteLine("Editar né, boa escolha!");
                    break;
            case Opcao.Listar:
                    Console.WriteLine("Listas são sempre úteis");
                    break;
            case Opcao.Atualizar:
                    Console.WriteLine("Update!");
                    break;
            default:
                    Console.WriteLine("Digite uma opção válida!");
                    break;
            }
        }
    }
}

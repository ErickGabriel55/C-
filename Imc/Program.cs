// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args){
            string classificacao;
            // Exibir a tabela de IMC
            Console.WriteLine("Tabela de Classificação de IMC:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|  Faixa de IMC      | Classificação                |");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("| Menos de 18,5     | Abaixo do peso               |");
            Console.WriteLine("| 18,5 - 24,9       | Peso normal                  |");
            Console.WriteLine("| 25,0 - 29,9       | Sobrepeso                    |");
            Console.WriteLine("| 30,0 - 34,9       | Obesidade grau 1             |");
            Console.WriteLine("| 35,0 - 39,9       | Obesidade grau 2             |");
            Console.WriteLine("| 40,0 ou mais      | Obesidade grau 3             |");
            Console.WriteLine("---------------------------------------------------");
            // 1 pedir o peso e altura
            Console.WriteLine("Qual seu peso?");
            float peso = float.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

            Console.WriteLine("Qual a sua altura?");
            float altura = float.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
            float imc = peso / (altura * altura);
            // 2 realizar as condições de classificação de pesos
            if (imc < 18.5)
            {
                classificacao = $"Seu imc é {imc:F2}\nVocê está muito magro, seu frango!";
            }
            else if (imc >= 18.5 && imc < 24.9){
                classificacao = $"Seu imc é {imc:F2}\nVocê está com o peso normal, Parabens!!!";
            }
            else if (imc >= 25.0 && imc < 29.9){
                classificacao = $"Seu imc é {imc:F2}\nVocê está com sobrepeso!";
            }
            else if (imc >= 30.0 && imc < 34.9){
                classificacao = $"Seu imc é {imc:F2}\nVocê está com obesidade grau 1!";
            }
            else if (imc >= 35.0 && imc < 39.9){
                classificacao = $"Seu imc é {imc:F2}\nVocê está com obesidade grau 2!";
            }
            else{
                classificacao = $"Seu imc é {imc:F2}\nVocê está com obesidade grau 3!";
            }
            // 3 retornar a resposta para o usuário
            Console.WriteLine(classificacao);
        }
    }
}

using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            Console.Write("Qual é a tabuada desejada? ");
            tabuada = Convert.ToInt32(Console.ReadLine());
            string valor = string.Empty;
            do
            { if (valor != string.Empty)
              {
                    tabuada = Convert.ToInt32(valor);
              }
              for (int i = 1; i <= 10; i++)
              {
                  Console.WriteLine("{0} X {1} = {2}", tabuada, i, i * tabuada);
              }
              Console.WriteLine();
              Console.Write("Digite a tabuada ou enter para sair");
              valor = Console.ReadLine();

            } while (valor != string.Empty);

            Console.ReadLine();
        }
    }
}

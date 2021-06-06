using System;
using Figgle;

namespace sequenciapares
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario="";
            string final ="Programa finalizado!";
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Exercício sequência de números pares");
                Console.WriteLine("------------------------------------");
                
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Sequência");
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("0. Sair ");
                Console.ResetColor();
                Console.WriteLine();

                Console.Write("Escolha sua opção ..: ");
                usuario = Console.ReadLine();
                Console.WriteLine();

                if (usuario== "1")
                {
                    sequenciapares();
                }

            } while (usuario != "0");
                    Console.WriteLine(FiggleFonts.Standard.Render(final));

        }
         static void sequenciapares()
        {
          int a=0;
          Console.Write("Digite um número: ");
          a=Convert.ToInt32(Console.ReadLine());
          

          for(int i = 0; i <= a;i++) {

              if(i%2==0){
                  Console.WriteLine(i);

              } 

              Console.WriteLine();

          }
          Console.ReadKey();
        }
    }
}

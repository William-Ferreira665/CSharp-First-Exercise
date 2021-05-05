using System;

namespace ExemploAula
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Exercício de Média\n");
           
            Console.Write("Digite o primeiro nota: ");
            double notaUm = double.Parse(Console.ReadLine());

            Console.Write("Digite o segunda nota: ");
            double notaDois = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceira nota: ");
            double notaTres = double.Parse(Console.ReadLine());

            double media = (notaUm + notaDois + notaTres) / 3;

            Console.WriteLine("\nnotas digitadas:\n1° Nota " + notaUm + "\n2° nota " + notaDois + "\n3° nota " + notaTres);
            Console.WriteLine("\nSua média final é " + Math.Round(media, 1).ToString());

            if (media <= 5){ 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você foi reprovado!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nFim do Programa");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você foi aprovado!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nFim do Programa");
            }

        }
    }
}
using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Array");

            string[] nomes = new string[3];
            int[] idades = new int[3];

            for (var contador = 0; contador < 3; contador++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Digite o {contador+1}º nome");
                nomes[contador] = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite a idade");
                idades[contador] = int.Parse(Console.ReadLine());

            }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nomes Cadastrados:");

            for (var contador = 0; contador < 3; contador++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Nome: "+nomes[contador]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Idade: "+idades[contador]);
            }
                Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao;

            Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------|");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("|                                    Creative Team Coders - Calculadora                               |");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("|                   [A] - Adição                                    [S] - Subtração                   |");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("|                   [M] - Multiplicação                             [D] - Divisão                     |");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("|                                         [X] - Fechar aplicação                                      |");
            Console.WriteLine("|                                                                                                     |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------|\n");
            Console.WriteLine("Escolhe uma opção: ");
            
            opcao = Console.ReadKey().KeyChar;
            
            Console.WriteLine(opcao);
        }
    }
}

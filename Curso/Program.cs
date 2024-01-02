using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    using System;

    class Program
    {
        static void Main()
        {
            int escolha;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Soma de números inteiros");
                Console.WriteLine("2. Opção 2");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção (0, 1 ou 2): ");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("========================= Soma de Números Inteiros =========================");
                        Console.WriteLine("\nPor gentileza, digite o valor 1");
                        int valor1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor 2");
                        int valor2 = int.Parse(Console.ReadLine());

                        int resultado = valor1 + valor2;
                        Console.WriteLine($"O resultado é: {resultado}");
                        break;
                    case 2:
                        Console.WriteLine("========================= Resultado de Diferença =========================");
                        Console.WriteLine("Seja bem vindo ao programa que lerá quatro valores inteiros A, B, C e D.");
                        Console.WriteLine("Será calculado e mostrado a diferença do produto onde A e B pelo produto de C e D.");

                        Console.WriteLine("\nPor gentileza, digite o primeiro valor:");
                        int val1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nPor gentileza, digite o segundo valor:");
                        int val2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nPor gentileza, digite o terceiro valor:");
                        int val3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nPor gentileza, digite o quarto valor:");
                        int val4 = int.Parse(Console.ReadLine());

                        int result1 = val1 + val2;
                        int result2 = val3 + val4;

                        int resulDiferença = result1 - result2;
                        Console.WriteLine($"A soma do primeiro resultado: {result1}.\n" +
                            $"A soma do segundo resultado: {result2}.\n" +
                            $"A diferença entre esses valores é de: {resulDiferença}.");
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa. Até mais!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (escolha != 0);
        }
    }
}

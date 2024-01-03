using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
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
                        Soma soma = new Soma();
                        soma.SomaCalc();
                        break;
                    case 2:
                        Diferenca diferenca = new Diferenca();
                        diferenca.Calc();
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

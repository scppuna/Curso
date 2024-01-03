using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    class Diferenca
    {
        public void Calc()
        {

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
        }
    }
}

using System;

namespace Curso
{
    internal class Soma
    {
        public void SomaCalc()
        {
            Console.WriteLine("========================= Soma de Números Inteiros =========================");
            Console.WriteLine("\nPor gentileza, digite o valor 1");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor 2");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = valor1 + valor2;
            Console.WriteLine($"O resultado é: {resultado}");
        }
    }
}
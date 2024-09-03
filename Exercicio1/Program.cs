using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[50];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            fibonacci[2] = 1;

            for (int i = 3; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1]; 
            }

            Console.Write("Digite um número para saber se ele está na sequência de Fibonacci: ");
            int numeroInserido = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Sequência de Fibonacci " + string.Join(", ", fibonacci));
            Console.WriteLine();

            if (fibonacci.Contains(numeroInserido))
            {
                Console.WriteLine("O número inserido está presente na sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine("O número inserido não está presente na sequência de Fibonacci");
            }
        }
    }
}
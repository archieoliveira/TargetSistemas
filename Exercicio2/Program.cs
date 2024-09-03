using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma string: ");
        string input = Console.ReadLine();

        int contador = 0;

        foreach (char caracter in input)
        {
            if (caracter == 'a' || caracter == 'A')
            {
                contador++;
            }
        }

        if (contador > 0)
        {
            Console.WriteLine($"A letra 'a' (maiúscula ou minúscula) foi encontrada {contador} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (maiúscula ou minúscula) não foi encontrada na string.");
        }
    }
}
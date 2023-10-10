//EXERCÍCIO 03

//Some os números de 1 a 100 a imprima o valor.

namespace Desafio14;

class Program
{
    static void Main()
    {
        int soma = 0;

        Console.WriteLine("Bem vindo ao somatório de 1 a 100 da ADA!");

        for (int i = 1; i <= 100; i++)
        {
            Console.Write($"[{i}] ");
            soma += i;
        }

        Console.WriteLine($"\n\nA soma de todos os elementos entre 1 e 100 é igual a {soma}");
    }
}
namespace Desafio13;

class Program
{
    static void Main()
    {
        int[] numInt = new int[10];
        int soma = 0, menor;
        float media;

        Console.WriteLine("Bem vindo a calculadora de Média, Soma e definição do menor número da ADA!");
        Console.WriteLine("Você precisa digitar 10 números\n");

        for (int i = 0; i < numInt.Length; i++)
        {
            do
            {
                Console.Write($"Digite {i + 1}°: ");

            } while (!int.TryParse(Console.ReadLine(), out numInt[i]));
        }

        for (int i = 0; i < numInt.Length; i++)
        {
            soma += (int)numInt[i];
        }

        media = (float)soma/numInt.Length;

        menor = numInt.Min();

        Console.Write($"\nOs 10 números são: ");

        for (int i = 0; i < numInt.Length; i++)
        {
            Console.Write($"[{numInt[i]}]" + " ");
        }

        Console.WriteLine($"\nO menor número é {menor}\nA média é {media:F2}\nA soma dos elementos é {soma}");
    }
}
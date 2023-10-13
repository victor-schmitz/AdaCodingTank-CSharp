//Escreva um programa que recebe como entrada uma frase do usuário. Como saída o programa deve exibir no console as seguintes informações: quantas palavras são maiúsculas, quantas palavras são minúsculas, quantas palavras iniciam com letra maiúscula, quantas palavras iniciam com letra minúscula e a quantidade de palavras.

namespace Questao03;

class Program
{
    static void Main()
    {
        try
        {
            string frase;
            int maiusc = 0;
            int minusc = 0;
            int inicMaiu = 0;
            int inicMin = 0;

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();

            string[] palavras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < palavras.Length; i++)
            {
                string palavra = palavras[i];

                if (string.IsNullOrEmpty(palavra))
                    continue;
                if (palavra == palavra.ToUpper())
                    maiusc++;
                if (palavra == palavra.ToLower())
                    minusc++;
                if (char.IsUpper(palavra[0]))
                    inicMaiu++;
                if (char.IsLower(palavra[0]))
                    inicMin++;
            }

            int totalPalavras = palavras.Length;

            Console.Write($"\nQuantidade de palavras totalmente maiúsculas: {maiusc}");
            Console.Write($"\nQuantidade de palavras totalmente minúsculas: {minusc}");
            Console.Write($"\nQuantidade de palavras que iniciam com letra maiúscula: {inicMaiu}");
            Console.Write($"\nQuantidade de palavras que iniciam com letra minúscula: {inicMin}");
            Console.Write($"\nQuantidade de palavras: {totalPalavras}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Digite uma frase válida.");
        }
    }
}
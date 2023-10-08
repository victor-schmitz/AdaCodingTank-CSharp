namespace Desafio10;

class Program
{
    static void Main()
    {
        string palavra, palavraDigitada; // Var

        Console.WriteLine("Bem vindo ao verificador de palíndromos da ADA!");

        do // Loop para que o usuário não deixe o campo vazio
        {
            Console.Write("\nDigite uma palavra para verificar se ela é um palíndromo: ");
            palavraDigitada = Console.ReadLine();
        } while (string.IsNullOrEmpty(palavraDigitada));

        palavra = palavraDigitada.ToUpper(); // Converte a palavra para maiusculo,já que Arara não seria considerada palindromo, pois "A" é considerado != "a"
        bool ehPalindromo;

        do
        {
            if (palavra.Length <= 1) // até o tamanho da string ser 1 ou 0
            {
                ehPalindromo = true;
                break;
            }
            else
            {
                if (palavra[0] == palavra[palavra.Length - 1]) // Compara a primeira e a ultima letra da palavra
                {
                    palavra = palavra.Substring(1, palavra.Length - 2); // Caso a primeira e a ultima letra sejam iguais, ele vai criar uma substring sem elas, agora a segunda e penultima se tornando a nova primeira e ultima
                }
                else
                {
                    ehPalindromo = false;
                    break;
                }
            }
        } while (true);

        if (ehPalindromo)
        {
            Console.WriteLine($"\nA palavra {palavraDigitada} é um palíndromo.");
        }
        else
        {
            Console.WriteLine($"\nA palavra {palavraDigitada} não é um palíndromo.");
        }
    }
}
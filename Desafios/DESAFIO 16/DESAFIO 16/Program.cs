namespace Desafio16;

class Program
{
    static void Main()
    {
        // Variáveis
        int primNum = 0, segNum = 0, somaPares = 0, posicNumeros = 0, posicNumPares = 0;
        int[] numeros = new int[1];
        int[] numerosPares = new int[1];

        Console.WriteLine("Bem vindo a calculadora da soma dos pares da ADA!");

        Console.WriteLine("\nVocê digitará um número de início, um número final e o programa irá somar todos os pares nesse intervalo de números.");

        try
        {
            while (true) // Loop para impedir que o usuário digite um valor nao valido
            {
                Console.Write("\nDigite o número inicial: ");

                if ((!int.TryParse(Console.ReadLine(), out primNum))) // se o que ele digitar nao tiver foi um inteiro
                {
                    Console.WriteLine("\nDigite um número válido como número inicial!\n");
                }
                else
                {
                    break;
                }
            }

            while (true)  // Loop para impedir que o usuário digite um valor nao valido
            {
                Console.Write("\nDigite o número final: ");

                if ((!int.TryParse(Console.ReadLine(), out segNum))) // se o que ele digitar nao tiver foi um inteiro
                {
                    Console.WriteLine("\nDigite um número válido como número final!\n");
                }
                else if (segNum < primNum) // Caso o segundo numero seja menor que o primeiro, ele impede
                {
                    Console.WriteLine($"\nO número final precisa ser maior que o número inicial ({primNum})!\n");
                }
                else
                {
                    break;
                }
            }

            numeros = new int[segNum - primNum + 1]; // atualização do tamanho do vetor de numeros

            for (int i = primNum; i <= segNum; i++)  // for para atualizar os valores dentro dos vetores dos numeros entre o primeiro e segundo numero e, caso seja par, atualiza o segundo vetor de pares
            {
                numeros[posicNumeros] = i;
                posicNumeros++;

                if (i % 2 == 0) // se for par
                {
                    Array.Resize(ref numerosPares, posicNumPares + 1);
                    numerosPares[posicNumPares] = i;
                    posicNumPares++;
                }
            }

            somaPares = numerosPares.Sum();

            Console.WriteLine($"\n\nEntre {primNum} e {segNum}, existem:\n");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"[{numeros[i]}] ");
            }

            Console.WriteLine($"\n\nEntre {primNum} e {segNum}, os seguintes números são pares:\n");

            for (int i = 0; i < numerosPares.Length; i++)
            {
                Console.Write($"[{numerosPares[i]}] ");
            }

            Console.WriteLine($"\n\nA soma de todos os números pares listados é: {somaPares}\n");

        }
        catch (Exception ex) //Exceção geral 
        {
            Console.WriteLine("\nDigite um número válido na próxima vez que for usar o programa.\n");
        }
    }
}
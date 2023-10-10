//03 - Escreva um programa em C# que solicite ao usuário que adivinhe um número secreto entre 1 e 100. O programa deve gerar aleatoriamente 
//o número secreto e fornecer dicas sobre se o palpite do usuário é maior ou menor do que o número secreto. O programa deve continuar pedindo 
//palpites até que o usuário adivinhe corretamente o número secreto.

namespace Desafio18;

class Program
{
    static void Main()
    {
        try
        {

            Console.WriteLine("Vamos descobrir um número secreto");

            Random random = new Random();

            int numSecreto = random.Next(1, 101);
            int tentativa = 0;

            while (true)
            {
                do
                {
                    Console.Write("Digite um número: ");
                } while (!int.TryParse(Console.ReadLine(), out tentativa));

                if (tentativa != numSecreto)
                {
                    if (tentativa < numSecreto)
                    {
                        Console.WriteLine("Tente novamente. Agora um número maior.");
                    }
                    else if (tentativa > numSecreto)
                    {
                        Console.WriteLine("Tente novamente. Agora um número menor.");
                    }
                }
                else
                {
                    Console.WriteLine($"\nVocê acertou! O número é {numSecreto}!");
                    break;
                }
            }

        } catch (Exception e)
        {
            Console.WriteLine("Digite um número válido.");
        }
    }
}
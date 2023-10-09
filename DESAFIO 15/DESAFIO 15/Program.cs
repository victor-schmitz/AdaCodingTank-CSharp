namespace Desafio15;

class Program
{
    static void Main()
    {
        int numero, quantNum = 0, soma = 0, pares = 0;
        Console.WriteLine("Vamos somar todos os números que você digitar, até que você digite 0 para parar.\n");

        while (true) // Loop para o usuário digitar N números, até que deseje parar
        {
            Console.Write("Digite um número (0 se quiser parar de contar): ");

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Digite um número válido.");
            }
            else if (numero != 0)
            {
                quantNum++;
                soma += numero;

                if (numero % 2 == 0)
                {
                    pares++;
                }
            }
            else if (numero == 0)
            {
                break;
            }
        } 

        Console.WriteLine($"Foram lidos {quantNum} números\nA soma dos números digitados foi {soma}\nE dos números digitados, {pares} eram pares");
    }
}
namespace Desafio06;

class Program
{
    static void Main()
    {
        // Variáveis
        int idade;

        Console.WriteLine("Bem vindo ao classificador de nadador da ADA!\n");

        while (true) // Loop para que o usuário não digite uma idade inválida
        {
            Console.Write("Digite a idade do nadador para que ele seja classificado: ");

            if (!int.TryParse(Console.ReadLine(), out idade) || idade < 5) // Caso a idade não seja um inteiro ou seja menor que 5 anos (também impede que seja uma idade negativa)
            {
                Console.WriteLine("\nDigite uma idade válida para o nadador (precisa ser maior que 5 anos).\n");
            }
            else
            {
                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("O nadador é classificado como Infantil A.");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("O nadador é classificado como Infantil B.");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("O nadador é classificado como Juvenil A.");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("O nadador é classificado como Juvenil B.");
                }
                else
                {
                    Console.WriteLine("O nadador é classificado como Adulto.");
                }
                break;
            }
        }
    }
}
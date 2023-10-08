namespace Desafio02;

class Program
{
    static void Main()
    {
        // Variáveis
        int anoNasc, anoAtual, idade;
        string anivFeito;

        Console.WriteLine("Bem vindo a Calculadora de Idade ADA.\n");

        while (true) // Loop para impedir que o usuário digite algo que não seja um inteiro
        {
            Console.Write("Digite o seu ano de nascimento (formato -> 2010): ");
            if (int.TryParse(Console.ReadLine(), out anoNasc))
            {
                while (true) // Loop para impedir que o usuário digite algo que não seja um inteiro
                { 
                Console.Write("Digite o ano atual (formato -> 2010): ");
                    if (int.TryParse(Console.ReadLine(), out anoAtual))
                    {
                        while (true) // Loop para verificar se o usuário digitou s ou n
                        {
                            Console.Write("Você já fez aniversário esse ano? (s/n): "); // Verificar se o aniversário já foi feito, para ver se é necessário remover 1 da idade, caso não tenha sido feito
                            anivFeito = Console.ReadLine();

                            if (anivFeito != "s" && anivFeito != "n")
                            {
                                Console.WriteLine("Digite s ou n como resposta.");
                            }
                            else
                            {
                                switch (anivFeito)
                                {
                                    case "s":
                                        idade = anoAtual - anoNasc;
                                        Console.WriteLine($"Você tem {idade} anos.");
                                        break;

                                    case "n":
                                        idade = (anoAtual - anoNasc) - 1;
                                        Console.WriteLine($"Você tem {idade} anos.");
                                        break;
                                }
                            break;
                            }                            
                        }
                        break;                        
                    }
                }
                break;
            }                      
        }
    }
}
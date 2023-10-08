namespace Desafio03;

class Program
{
    static void Main()
    {
        // Variáveis
        float conta, total, gorjeta, percGorjeta;

        Console.WriteLine("Bem vindo à Calculadora de Gorgeta da ADA!\n");

        while (true) // Loop que vai impedir o usuário de digitar algo que não se enquadre como o valor da conta
        {
            Console.Write("Vamos calcular sua conta. Digite qual o valor da sua conta (Só números, exemplo: 150 reais = 150): ");
            if (!float.TryParse(Console.ReadLine(), out conta) || conta < 0 || conta == 0) 
            {
                Console.WriteLine("Digite o valor correto da conta\n");
            }
            else
            {
                while (true) // Loop que vai impedir o usuário de digitar algo que não se enquadre como o percentual
                {                    
                    Console.WriteLine("\n0 para não deixar gorjeta :(");
                    Console.WriteLine("15 para deixar 15% de gorjeta :)");
                    Console.WriteLine("20 para deixar 20% de gorjeta :D");
                    Console.Write("Agora, digite a porentagem de gorjeta a ser paga: ");

                    if (!float.TryParse(Console.ReadLine(), out percGorjeta) || percGorjeta != 0 && percGorjeta != 15 && percGorjeta != 20)
                    {
                        Console.WriteLine("\nDigite uma das 3 opções.\n");
                    }
                    else
                    {
                        total = (conta * ((percGorjeta / 100) + 1));
                        Console.WriteLine($"\nO total da sua conta, com o acrescimo da gorjeta, foi de: R${total:F2}");
                        break;                  
                    }                    
                }
                break;
            }
        }
    }
}
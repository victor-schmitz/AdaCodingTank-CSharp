//DESAFIO 05:

//Sr.José, pescador, comprou um microcomputador para
//controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de
//peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo
//(50 quilos) deve pagar uma multa de R$4,00 por quilo excedente. Sr. José, precisa que
//você faça programa que leia o peso de peixes e verifique se há excesso.
//Se houver, gravar o Excesso e o valor da multa que Sr. José
//deverá pagar. Caso contrário mostrar os valores com o conteúdo ZERO. 
//Apresentar as mensagens no console.

namespace Desafio05;

class Program
{
    static void Main()
    {
        float pesoEstabelecido = 50.00f; // 50 quilos
        int multa = 0; // multa inicialmente é 0
        string pesoDigitado;
        float pesoExcedido;
        float checarPeso; // usada para checar se o peso é um número maior ou igual a 0
        Boolean pesoVazio = false; // boolean para caso o usuário não digite um peso

        while (!pesoVazio) 
        {
            // Armazena o valor dos peixes como uma string
            Console.Write("Digite o peso dos seus peixes: ");
            pesoDigitado = Console.ReadLine(); 

            // faz todas as verificações para ver se pode seguir
            if (pesoDigitado == null || pesoDigitado == "" || !float.TryParse(pesoDigitado, out checarPeso) || checarPeso < 0) 
            {
                Console.WriteLine("Digite um número válido para o peso dos peixes.\n");
            }
            else
            {
                // atinge a condição de parada do while
                pesoVazio = true; 

                //convertendo o valor dos peixes para um float
                float peso = Single.Parse(pesoDigitado);

                if (peso > pesoEstabelecido)
                {
                    pesoExcedido = peso - pesoEstabelecido;
                    multa = ((int)Math.Floor(pesoExcedido) * 4); // Math.Floor converte o float para o inteiro abaixo dele, ex: 5,9 vai virar 5

                    Console.WriteLine($"\nVocê ultrapassou {pesoExcedido:F2} quilos.");
                    Console.WriteLine($"Sua multa é de R${multa},00");
                }
                else
                {
                    Console.WriteLine("\nNão há multa, pois você não ultrapassou o limite de peso.");
                    Console.WriteLine($"Multa = R${multa},00");
                }
            }
        }
    }
}
namespace Desafio06;

class Program
{
    static void Main()
    {
        string idadeString;
        int checarIdade; // checa as condições para o usuário não digitar uma idade inválida
        Boolean idadeVazio = false;


        while (!idadeVazio)
        {
            // Armazena o valor do nadador como uma string
            Console.Write("Digite a idade do nadador: ");
            idadeString = Console.ReadLine();

            // faz todas as verificações para ver se pode seguir
            if (idadeString == null || idadeString == "" || !int.TryParse(idadeString, out checarIdade) || checarIdade < 0)
            {
                Console.WriteLine("Digite uma idade válida\n");
            }
            else
            {
                // atinge a condição de parada do while
                idadeVazio = true;

                //convertendo o valor da idade para um int
                int idade = int.Parse(idadeString);

                if (idade < 5)
                {
                    Console.WriteLine("Não pode ser um nadador, visto que é menor do que 5 anos.");
                }
                else if (5 <= idade && idade <= 7)
                {
                    Console.WriteLine("O nadador é classificado como Infantil A.");
                }
                else if (8 <= idade && idade <= 11)
                {
                    Console.WriteLine("O nadador é classificado como Infantil B.");
                }
                else if (12 <= idade && idade <= 13)
                {
                    Console.WriteLine("O nadador é classificado como Juvenil A.");
                }
                else if (14 <= idade && idade <= 17)
                {
                    Console.WriteLine("O nadador é classificado como Juvenil B.");
                }
                else
                {
                    Console.WriteLine("O nadador é classificado como Adulto.");
                }
            }
        }
    }
}



































        

 
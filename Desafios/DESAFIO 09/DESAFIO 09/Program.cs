namespace Desafio09;

class Program
{
    static void Main()
    {
        int escolha;

        Console.WriteLine("Bem vindo à ADA!");

        do
        {
            Console.WriteLine("\nEsses são os nossos cursos disponíveis no momento para inscrição:");
            Console.WriteLine("1 para Back-End em C#");
            Console.WriteLine("2 para Back-End em Java");
            Console.WriteLine("3 para DevOps");
            Console.Write("Digite a opção do curso que você deseja se inscrever: ");
        } while (!int.TryParse(Console.ReadLine(), out escolha) || escolha != 1 && escolha != 2 && escolha != 3);

        switch (escolha)
        {
            case 1:
                Console.WriteLine("\nVocê agora está inscrito no curso Back-End em C#");
                break;

            case 2:
                Console.WriteLine("\nVocê agora está inscrito no curso Back-End em Java");
                break;

            case 3:
                Console.WriteLine("\nVocê agora está inscrito no curso DevOps");
                break;
        }
    }
}
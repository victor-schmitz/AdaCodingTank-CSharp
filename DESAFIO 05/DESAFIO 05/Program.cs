namespace Desafio05;

class Program
{
    static void Main()
    {
        // Variáveis
        float pesoLimite = 50;
        float pesoPeixes;
        float multaFloat = 0; // Vai ser arredondada para o primeiro inteiro abaixo dela para calcular multa
        int multaInt;

        Console.WriteLine("Bem vindo ao verificador de peso e multa de peixes da ADA!\n");

        while (true)
        {
            Console.Write("Digite o peso de peixes que você tem: ");

            if (!float.TryParse(Console.ReadLine(), out pesoPeixes) || pesoPeixes < 0)
            {
                Console.WriteLine("\nDigite um peso válido.\n");
            }
            else
            {
                if (pesoPeixes < pesoLimite)
                {
                    Console.WriteLine($"\nSeu peso é {pesoPeixes} quilos e você não excedeu o limite.\nSua multa é R$ {multaFloat:F2}");
                }
                else
                {
                    {
                        multaFloat = pesoPeixes - pesoLimite;
                        multaInt = (int)multaFloat * 4;
                        Console.WriteLine($"\nSeu peso é {pesoPeixes} e você excedeu {multaFloat} quilos.\nSua multa é de R$ {multaInt}");
                    }
                }
                break;
            }
        }
    }
}
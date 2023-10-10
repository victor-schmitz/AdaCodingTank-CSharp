namespace Desafio17;

class Program
{
    static void Main()
    {
        int termoParada = 0;
        int[] fibonacci = new int[1];
        try
        {
            while (true)
            {
                Console.Write("Digite o número de parada da sequencia: ");
                if (!int.TryParse(Console.ReadLine(), out termoParada))
                {
                    Console.WriteLine("Digite um número inteiro.");
                }
                else if (termoParada < 0)
                {
                    Console.WriteLine("Digite um número maior que 0");
                }
                else
                {
                    break;
                }
            }
            Array.Resize(ref fibonacci, termoParada);

            if (termoParada >= 1)
            {
                fibonacci[0] = 0;
            }
            if (termoParada >= 2)
            {
                fibonacci[1] = 1;
            }

            for (int i = 2; i < termoParada; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.Write($"Os {termoParada} primeiros números da sequencia fibonacci são: ");

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.Write($"[{fibonacci[i]}] ");
            }
        } catch (Exception ex)
        {
            Console.WriteLine("Digite valores que sejam válidos na próxima vez que rodar");
        }
    }
}
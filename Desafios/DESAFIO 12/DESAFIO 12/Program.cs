namespace Desafio12;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo a soma de vetores da ADA.");

        Random random = new Random(); // Import da classe random para gerar os valores aleatorios dos vetores
        int[] vetorA = new int[10];
        int[] vetorB = new int[10];
        int[] vetorC = new int[vetorA.Length]; // declarando que o vetorC vai ter o mesmo comprimento do vetorA

        for (int i = 0; i < vetorA.Length; i++)
        {
            vetorA[i] = random.Next(1, 100); // Add valores aleatorios entre 1 e 100 no vetor
        }

        Console.Write("Vetor A: ");

        for (int i = 0; i < vetorA.Length; i++)
        {
            Console.Write($"[{vetorA[i]}]" + " "); // Loop para imprimir o vetor
        }

        for (int i = 0; i < vetorB.Length; i++)
        { 
            vetorB[i] = random.Next(1, 100); // Add valores aleatorios entre 1 e 100 no vetor
        }

        Console.WriteLine("\n");
        Console.Write("Vetor B: ");

        for (int i = 0; i < vetorB.Length; i++)
        {
            Console.Write($"[{vetorB[i]}]" + " "); // Loop para imprimir o vetor
        }

        Array.Reverse(vetorB); // Invertendo o vetor B, visto que deve-se somar o primeiro elemento do A com o ultimo do B, e assim por diante

        for (int i = 0; i < vetorC.Length; i++)
        {
            vetorC[i] = vetorA[i] + vetorB[i]; // Soma dos elementos dos vetores A e B, resultando no C
        }

        Console.WriteLine("\n");
        Console.Write("Vetor C: ");

        for (int i = 0; i < vetorC.Length; i++)
        {
            Console.Write($"[{vetorC[i]}]" + " "); // Loop para imprimir o vetor
        }
    }
}
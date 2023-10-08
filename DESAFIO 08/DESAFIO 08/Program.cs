namespace Desafio08;

class Program
{
    static void Main()
    {
        // Var
        float prova1, prova2, prova3, provaFinal, media, mediaFinal;

        Console.WriteLine("Bem vindo a Calculadora de Médias da ADA!");

        do
        {
            Console.Write("\nDigite a nota da sua primeira prova: ");
        } while (!float.TryParse(Console.ReadLine(), out prova1) || prova1 < 0 || prova1 > 10);

        do
        {
            Console.Write("\nDigite a nota da sua segunda prova: ");
        } while (!float.TryParse(Console.ReadLine(), out prova2) || prova2 < 0 || prova2 > 10);

        do
        {
            Console.Write("\nDigite a nota da sua terceira prova: ");
        } while (!float.TryParse(Console.ReadLine(), out prova3) || prova3 < 0 || prova3 > 10);

        media = (prova1 + prova2 + prova3) / 3;

        if (media >= 7)
        {
            Console.WriteLine($"\nParabéns, você foi aprovado!\nSua média foi {media:F2}");
        }
        else
        {
            Console.WriteLine($"\nVocê ainda não foi aprovado.\nSua média foi {media:F2}");
            do
            {
                Console.Write("\nDigite a nota da sua prova final: ");
            } while (!float.TryParse(Console.ReadLine(), out provaFinal) || provaFinal < 0 || provaFinal > 10);

            mediaFinal = (provaFinal + media) / 2;

            if (mediaFinal >= 5)
            {
                Console.WriteLine($"\nParabéns, você foi aprovado na final!\nSua média foi {mediaFinal:F2}");
            }
            else
            {
                Console.WriteLine($"\nVocê não foi aprovado.\nSua média foi {mediaFinal:F2}");
            }
        }
    }
}
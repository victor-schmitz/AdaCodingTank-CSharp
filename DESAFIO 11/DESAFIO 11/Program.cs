namespace Desafio11;

class Program
{
    static void Main()
    {
        float salarioAntes, percAum, valorAum, salarioNovo;

        Console.WriteLine("Bem vindo ao Reajustador de Salários da ADA!");

        do
        {
            Console.Write("\nDigite o seu salário para calcular o aumento (só números): ");
        } while (!float.TryParse(Console.ReadLine(), out salarioAntes) || salarioAntes <= 0);

        if (salarioAntes <= 280)
        {
            percAum = 20;
            salarioNovo = ((percAum / 100) + 1) * salarioAntes;
            valorAum = salarioNovo - salarioAntes;

            Console.WriteLine($"\nO seu salário antes do reajuste era de R$ {salarioAntes:F2}");
            Console.WriteLine($"O percentual de aumento aplicado foi de {percAum}%");
            Console.WriteLine($"O valor do aumento foi de R$ {valorAum:F2}");
            Console.WriteLine($"O seu novo salário, após o aumento, é de R$ {salarioNovo:F2}\n");
        }
        else if (salarioAntes > 280 && salarioAntes <= 700)
        {
            percAum = 15;
            salarioNovo = ((percAum / 100) + 1) * salarioAntes;
            valorAum = salarioNovo - salarioAntes;

            Console.WriteLine($"\nO seu salário antes do reajuste era de R$ {salarioAntes:F2}");
            Console.WriteLine($"O percentual de aumento aplicado foi de {percAum}%");
            Console.WriteLine($"O valor do aumento foi de R$ {valorAum:F2}");
            Console.WriteLine($"O seu novo salário, após o aumento, é de R$ {salarioNovo:F2}\n");
        }
        else if (salarioAntes > 700 && salarioAntes <= 1500)
        {
            percAum = 10;
            salarioNovo = ((percAum / 100) + 1) * salarioAntes;
            valorAum = salarioNovo - salarioAntes;

            Console.WriteLine($"\nO seu salário antes do reajuste era de R$ {salarioAntes:F2}");
            Console.WriteLine($"O percentual de aumento aplicado foi de {percAum}%");
            Console.WriteLine($"O valor do aumento foi de R$ {valorAum:F2}");
            Console.WriteLine($"O seu novo salário, após o aumento, é de R$ {salarioNovo:F2}\n");
        }
        else
        {
            percAum = 5;
            salarioNovo = ((percAum / 100) + 1) * salarioAntes;
            valorAum = salarioNovo - salarioAntes;

            Console.WriteLine($"\nO seu salário antes do reajuste era de R$ {salarioAntes:F2}");
            Console.WriteLine($"O percentual de aumento aplicado foi de {percAum}%");
            Console.WriteLine($"O valor do aumento foi de R$ {valorAum:F2}");
            Console.WriteLine($"O seu novo salário, após o aumento, é de R$ {salarioNovo:F2}\n");
        }
    }
}
//2 - Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números inteiros, N1 por N2, que devem ser lidos do teclado. É importante observar que a máquina que irá executar este programa é capaz de efetuar apenas duas operações matemáticas: adição e subtração. Ou seja, você não poderá usar os operadores de multiplicação, divisão, módulo etc. bem como truncamentos.

namespace Questão2;

class Program
{
    static void Main()
    {
        int n1, n2, n1Mult, n2Mult, n1Div, n2Div, mult = 0, n1Abs, n2Abs;
        float div = 0;
        bool opNeg;

        try
        {
            Console.Write("Vamos fazer a multiplicação e divisão de 2 números (N1 e N2).\n");

            while (true)
            {
                Console.Write("Digite um valor para N1: ");
                if (!int.TryParse(Console.ReadLine(), out n1))
                {
                    Console.WriteLine("\nDigite um número inteiro como valor.");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Digite um valor para N2: ");
                if (!int.TryParse(Console.ReadLine(), out n2))
                {
                    Console.WriteLine("\nDigite um número inteiro como valor.");
                }
                else if (n2 == 0)
                {
                    Console.WriteLine("Não é possível que o N2 seja 0, por causa da divisão.");
                }
                else
                {
                    break;
                }
            }

            opNeg = (n1 < 0 && n2 > 0) || (n1 > 0 && n2 < 0);
            
            n1Abs = Math.Abs(n1); // Para caso seja realizada uma operação de mult com um dos dois n negativos, ao menos
            n2Abs = Math.Abs(n2);

            // Multiplicação
            n1Mult = n1Abs; // valores absolutos
            n2Mult = n2Abs;

            if (opNeg)
            {
                n1Mult = -n1Mult; // Inverte o sinal do primeiro número negativo
            }

            for (int i = 0; i < n2Mult; i++)
            {
                mult += n1Mult;
            }

            if (opNeg)
            {
                mult = -mult; // Inverte o resultado quando um dos números é negativo
            }

            // Divisão
            n1Div = n1Abs;
            n2Div = n2Abs;

            while (n1Div >= n2Div)
            {
                n1Div -= n2Div;
                div++;
            }

            if (opNeg)
            {
                mult = -mult; // se a operação tiver apenas um n negativo, ele inverte o resultado, ja que + com - é -
                div = -div;   // também inverte o resultado da divisão
            }

            Console.WriteLine($"A multiplicação é igual a {mult}");

            if (n1 < n2)
            {
                Console.WriteLine($"{n1} é menor que {n2}, logo a parte inteira da divisão é 0.");
            }
            else
            {
                Console.WriteLine($"{n1} / {n2} = {div}, tendo {n1Div} como resto"); // n1Div acaba se tornando o resto
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Na próxima vez que rodar, digite um número válido!");
        }
    }
}
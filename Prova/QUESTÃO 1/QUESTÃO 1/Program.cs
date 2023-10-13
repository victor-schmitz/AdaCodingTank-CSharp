//1 - Escreva um programa que faça a leitura de 5 valores Inteiros do usuário. Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos. Cada uma das informações deve ser escrita em uma linha diferente.

namespace Questão1;

class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int[] vetPar = new int[1];
        int[] vetImp = new int[1];
        int[] vetPos = new int[1];
        int[] vetNeg = new int[1];
        int numeroAtual = 0, num0 = 0, numPos = 0, numNeg = 0, numPar = 0, numImpar = 0;

        Console.WriteLine("Digite 5 valores inteiros.");
        
        try
        {
            for (int i = 0; i < numeros.Length; i++)
            {                
                while (true)
                {
                    Console.Write($"Digite o {i + 1}° valor: ");
                    if (!int.TryParse(Console.ReadLine(), out numeroAtual))
                    {
                        Console.WriteLine("Digite um número inteiro!");
                    }
                    else
                    {
                        if (numeroAtual == 0)
                        {
                            num0++;
                        }
                        else if (numeroAtual > 0)
                        {
                            Array.Resize(ref vetPos, numPos + 1);
                            vetPos[numPos] = numeroAtual;
                            numPos++;
                        }
                        else if (numeroAtual < 0)
                        {
                            Array.Resize(ref vetNeg, numNeg + 1);
                            vetNeg[numNeg] = numeroAtual;
                            numNeg++;
                        }
                        if (numeroAtual % 2 == 0)
                        {
                            Array.Resize(ref vetPar, numPar + 1);
                            vetPar[numPar] = numeroAtual;
                            numPar++;
                        }
                        else
                        {
                            Array.Resize(ref vetImp, numImpar + 1);
                            vetImp[numImpar] = numeroAtual;
                            numImpar++;
                        }
                        break;
                    }
                }
                numeros[i] = numeroAtual;
            }
            Console.Write("\nVocê digitou os seguintes números: ");

            for ( int i = 0;  i < numeros.Length; i++)
            {
                Console.Write($"[{numeros[i]}] ");
            }

            if (numPar > 0)
            {
                Console.Write($"\n\nDesses, os seguintes {numPar} são PARES: ");

                for (int i = 0; i < vetPar.Length; i++)
                {
                    Console.Write($"[{vetPar[i]}] ");
                }
            }
            else
            {
                Console.WriteLine("\nVocê não digitou nenhum número PAR.");
            }

            if (numImpar > 0)
            {
                Console.Write($"\n\nE os seguintes {numImpar} são ÍMPARES: ");

                for (int i = 0; i < vetImp.Length; i++)
                {
                    Console.Write($"[{vetImp[i]}] ");
                }
            }
            else
            {
                Console.WriteLine("\nVocê não digitou nenhum número ÍMPAR.");
            }

            if (numPos > 0)
            {
                Console.Write($"\n\nDe todos os números, {numPos} são POSITIVOS: ");

                for (int i = 0; i < vetPos.Length; i++)
                {
                    Console.Write($"[{vetPos[i]}] ");
                }
            }
            else
            {
                Console.WriteLine("\nVocê não digitou nenhum número POSITIVO.");
            }

            if (numNeg > 0)
            {
                Console.Write($"\n\nE {numNeg} são NEGATIVOS: ");

                for (int i = 0; i < vetNeg.Length; i++)
                {
                    Console.Write($"[{vetNeg[i]}] ");
                }
            }
            else
            {
                Console.WriteLine("\nVocê não digitou nenhum número NEGATIVO.");
            }

            if (num0 > 0)
            {
                Console.Write($"\n\nAlém disso, você digitou [{num0}] zeros(0), que não é nem positivo, nem negativo.");
            }
            else
            {
                Console.WriteLine("\nVocê não digitou nenhum [0], que não é POSITIVO, nem NEGATIVO\n");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Digite um valor válido na próxima vez que rodar o programa.");
        }

    }
}
using System;

class Program
{
    static void Main()
    {
        // Defina as dimensões da matriz tridimensional
        int dimensao1 = 3; // Primeira dimensão
        int dimensao2 = 4; // Segunda dimensão
        int dimensao3 = 2; // Terceira dimensão

        // Crie a matriz tridimensional
        int[,,] matriz3D = new int[dimensao1, dimensao2, dimensao3];

        // Preencha a matriz com valores
        for (int i = 0; i < dimensao1; i++)
        {
            for (int j = 0; j < dimensao2; j++)
            {
                for (int k = 0; k < dimensao3; k++)
                {
                    matriz3D[i, j, k] = i + j + k;
                }
            }
        }

        // Acesse e imprima valores da matriz
        Console.WriteLine("Valores da matriz tridimensional:");
        for (int i = 0; i < dimensao1; i++)
        {
            for (int j = 0; j < dimensao2; j++)
            {
                for (int k = 0; k < dimensao3; k++)
                {
                    Console.WriteLine($"matriz3D[{i}, {j}, {k}] = {matriz3D[i, j, k]}");
                }
            }
        }
    }
}

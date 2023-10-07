namespace Desafio01;

class Program
{
    static void Main()
    {
        int opcaoInt;
        float num1, num2, resultado;
        Boolean fecharPrograma = false;

        Console.WriteLine("Bem vindo à Calculadora ADA.");

        while (!fecharPrograma)
        {
            Console.WriteLine("Selecione qual operação você deseja realizar:\n");
            Console.WriteLine("1 para ADIÇÃO");
            Console.WriteLine("2 para SUBTRAÇÃO");
            Console.WriteLine("3 para MULTIPLICAÇÃO");
            Console.WriteLine("4 para DIVISÃO");
            Console.WriteLine("5 para FECHAR o programa\n");
            string opcao = Console.ReadLine();

            if (opcao == null || opcao == "" || !int.TryParse(opcao, out opcaoInt) || opcaoInt < 1 || opcaoInt > 5)
            {
                Console.WriteLine("Digite um valor entre 1 e 5.");
            }
            else
            {
                switch (opcaoInt)
                {
                    case 1:
                        Console.WriteLine("\nVocê escolheu a SOMA.");

                        while (true)
                        {
                            Console.Write("Digite o primeiro valor: ");
                            if (float.TryParse(Console.ReadLine(), out num1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a SOMA.\n");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Digite o segundo valor: ");
                            if (float.TryParse(Console.ReadLine(), out num2))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a SOMA.\n");
                            }
                        }

                        resultado = num1 + num2;

                        Console.WriteLine($"\nO resultado da soma de {num1} + {num2} = {resultado}\n\n");
                        break;

                    case 2:
                        Console.WriteLine("\nVocê escolheu a SUBTRAÇÃO.");

                        while (true)
                        {
                            Console.Write("Digite o primeiro valor: ");
                            if (float.TryParse(Console.ReadLine(), out num1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a SUBTRAÇÃO.\n");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Digite o segundo valor: ");
                            if (float.TryParse(Console.ReadLine(), out num2))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a SUBTRAÇÃO.\n");
                            }
                        }

                        resultado = num1 - num2;

                        Console.WriteLine($"\nO resultado da SUBTRAÇÃO de {num1} - {num2} = {resultado}\n\n");
                        break;

                    case 3:
                        Console.WriteLine("\nVocê escolheu a MULTIPLICAÇÃO.");

                        while (true)
                        {
                            Console.Write("Digite o primeiro valor: ");
                            if (float.TryParse(Console.ReadLine(), out num1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a MULTIPLICAÇÃO.\n");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Digite o segundo valor: ");
                            if (float.TryParse(Console.ReadLine(), out num2))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a MULTIPLICAÇÃO.\n");
                            }
                        }

                        resultado = num1 * num2;

                        Console.WriteLine($"\nO resultado da MULTIPLICAÇÃO de {num1} * {num2} = {resultado}\n\n");
                        break;

                    case 4:
                        Console.WriteLine("\nVocê escolheu a DIVISÃO.");

                        while (true)
                        {
                            Console.Write("Digite o primeiro valor: ");
                            if (float.TryParse(Console.ReadLine(), out num1))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a DIVISÃO.\n");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Digite o segundo valor: ");
                            if (float.TryParse(Console.ReadLine(), out num2) && num2 != 0)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nDigite um número válido para a DIVISÃO.\n");
                            }
                        }

                        resultado = num1 / num2;

                        Console.WriteLine($"\nO resultado da DIVISÃO de {num1} / {num2} = {resultado}\n\n");
                        break;

                    case 5:
                        fecharPrograma = true;
                        Console.WriteLine("\nObrigado por usar a calculadora ADA! Volte sempre!");
                        break;
                }
            }
        }
    }
}
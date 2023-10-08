
namespace Desafio07;

class Program
{
    static void Main()
    {
        // Var
        int escolha;
        int quantProd1 = 0;
        int quantProd2 = 0;
        int quantProd3 = 0;
        float total;
        float totalProd1 = 0;
        float totalProd2 = 0;
        float totalProd3 = 0;
        float prod1Preco = 10.50f;
        float prod2Preco = 20;
        float prod3Preco = 13.75f;
        bool fecharCarrinho = false;
        string codProd1 = "1";
        string codProd2 = "2";
        string codProd3 = "3";

        Console.WriteLine("Bem vindo a loja de produtos eletrônicos da ADA!");

        while (!fecharCarrinho) // Loop para fazer o usuário digitar valores válidos sem fechar o programa
        {
            Console.WriteLine("\nSegue a lista com os produtos disponíveis:\n");
            Console.WriteLine("1 para Produto 1 -> R$ 10,50");
            Console.WriteLine("2 para Produto 2 -> R$ 20,00");
            Console.WriteLine("3 para Produto 3 -> R$ 13,75");
            Console.WriteLine("4 para fechar a compra\n");
            Console.Write("Digite a opção do produto que você deseja: ");

            while (!int.TryParse(Console.ReadLine(), out escolha) || escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4)
            {
                Console.WriteLine("\nDIGITE UMA OPÇÃO VÁLIDA\n");
                Console.WriteLine("1 para Produto 1 -> R$ 10,50");
                Console.WriteLine("2 para Produto 2 -> R$ 20,00");
                Console.WriteLine("3 para Produto 3 -> R$ 13,75");
                Console.WriteLine("4 para fechar a compra\n");
                Console.Write("Digite a opção do produto que você deseja: ");
            }
            switch (escolha)
            {
                case 1:
                    do
                    {
                        Console.Write("\nDigite quantas unidades do produto 1 você deseja: ");
                    } while (!int.TryParse(Console.ReadLine(), out quantProd1) || quantProd1 < 0);
                    totalProd1 = quantProd1 * prod1Preco;
                    Console.WriteLine($"Você adicionou {quantProd1} produtos 1, que custaram R$ {totalProd1:F2}, ao seu carrinho.");
                    break;

                case 2:
                    do
                    {
                        Console.Write("\nDigite quantas unidades do produto 2 você deseja: ");
                    } while (!int.TryParse(Console.ReadLine(), out quantProd2) || quantProd2 < 0);
                    totalProd2 = quantProd2 * prod2Preco;
                    Console.WriteLine($"Você adicionou {quantProd2} produtos 2, que custaram R$ {totalProd2:F2}, ao seu carrinho.");
                    break;

                case 3:
                    do
                    {
                        Console.Write("\nDigite quantas unidades do produto 3 você deseja: ");
                    } while (!int.TryParse(Console.ReadLine(), out quantProd3) || quantProd3 < 0);
                    totalProd3 = quantProd3 * prod3Preco;
                    Console.WriteLine($"Você adicionou {quantProd3} produtos 3, que custaram R$ {totalProd3:F2}, ao seu carrinho.");
                    break;

                case 4:
                    total = totalProd1 + totalProd2 + totalProd3;
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine($"\nValor total do carrinho: R$ {total:F2}");
                    Console.WriteLine("RESUMO:");
                    if (quantProd1 > 0)
                    {
                        Console.WriteLine($"\nProduto 1:\nCódigo: {codProd1}\nQuantidade: {quantProd1}\nValor unitário: R$ {prod1Preco}\nValor Total do Produto 1: R$ {totalProd1:F2}\n");
                    }
                    if (quantProd2 > 0)
                    {
                        Console.WriteLine($"\nProduto 2:\nCódigo: {codProd2}\nQuantidade: {quantProd2}\nValor unitário: R$ {prod2Preco}\nValor Total do Produto 2: R$ {totalProd2:F2}\n");
                    }
                    if (quantProd3 > 0)
                    {
                        Console.WriteLine($"\nProduto 3:\nCódigo: {codProd3}\nQuantidade: {quantProd3}\nValor unitário: R$ {prod3Preco}\nValor Total do Produto 3: R$ {totalProd3:F2}\n");
                    }
                    Console.WriteLine("------------------------------------------------");

                    fecharCarrinho = true;
                    break;
            }
        }
    }
}
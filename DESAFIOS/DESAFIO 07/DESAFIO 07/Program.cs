//DESAFIO 07:

//Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
//para a organização de um sistema de gerenciamento de vendas. Elabore um algoritmo que,
//a partir de dados fornecidos pelo usuário, calcule o valor da venda de um produto,
//exibindo uma saída em vídeo contendo o código do produto, o nome, a quantidade
//comprada, o valor unitário e o valor total.

namespace Desafio07;

class Program
{
    static void Main()
    {
        string produtoA = "produto A";
        string produtoB = "produto B";
        string produtoC = "produto C";
        string produtoD = "produto D";
        string codProdA = "01";
        string codProdB = "02";
        string codProdC = "03";
        string codProdD = "04";
        float valorProdA = 10.50f;
        float valorProdB = 21.00f;
        float valorProdC = 5.75f;
        float valorProdD = 11.25f;
        int quantA = 0;
        int quantB = 0;
        int quantC = 0;
        int quantD = 0;
        float valorTotal;
        Boolean fecharCarrinho = false;

        Console.WriteLine("Bem vindo à loja. Os seguintes produtos estão disponíveis:\n");

        Console.WriteLine(produtoA + $" = R${valorProdA:F2}");
        Console.WriteLine(produtoB + $" = R${valorProdB:F2}");
        Console.WriteLine(produtoC + $" = R${valorProdC:F2}");
        Console.WriteLine(produtoD + $" = R${valorProdD:F2}");

        while (!fecharCarrinho)
        {

            Console.WriteLine("\nVamos começar a adicionar itens ao seu carriho.\n");
            Console.WriteLine("Digite 1 para adicionar o produto A ao seu carrinho.");
            Console.WriteLine("Digite 2 para adicionar o produto B ao seu carrinho.");
            Console.WriteLine("Digite 3 para adicionar o produto C ao seu carrinho.");
            Console.WriteLine("Digite 4 para adicionar o produto D ao seu carrinho.");
            Console.WriteLine("Digite 5 para fechar o carrinho.");

            Console.Write("\nDigite qual item você quer adicionar (entre 1 e 5): ");
            string escolhaString = Console.ReadLine();
            int escolha;

            

            if (escolhaString == null || escolhaString == "" || !int.TryParse(escolhaString, out escolha) || escolha < 1 || escolha > 5)
            {
                Console.WriteLine("\nDigite um número entre 1 e 5");
            }
            else
            {
                switch (escolha)
                {
                    case 1:
                        Console.Write("Quantos produtos A você deseja? ");
                        string QtdA = Console.ReadLine();
                        int AtualQuantA = int.Parse(QtdA);
                        quantA = quantA + AtualQuantA;
                        float valorTotalA = quantA * valorProdA;
                        break;

                    case 2:
                        Console.Write("Quantos produtos B você deseja? ");
                        string QtdB = Console.ReadLine();
                        int AtualQuantB = int.Parse(QtdB);
                        quantB = quantB + AtualQuantB;
                        float valorTotalB = quantB * valorProdB;
                        break;

                    case 3:
                        Console.Write("Quantos produtos C você deseja? ");
                        string QtdC = Console.ReadLine();
                        int AtualQuantC = int.Parse(QtdC);
                        quantC = quantC + AtualQuantC;
                        float valorTotalC = quantC * valorProdC;
                        break;

                    case 4:
                        Console.Write("Quantos produtos D você deseja? ");
                        string QtdD = Console.ReadLine();
                        int AtualQuantD = int.Parse(QtdD);
                        quantD = quantD + AtualQuantD;
                        float valorTotalD = quantD * valorProdD;
                        break;

                    case 5:
                        fecharCarrinho = true;
                        break;

                }
            }
        }
        Console.WriteLine("Segue o resumo do seu carrinho:\n");

        if (quantA != 0)
        {
            Console.WriteLine($"Produto A: \n Quantidade = {quantA} \n valor unitário = {valorProdA} \n Código = {codProdA}\n");
        }
        if (quantB != 0)
        {
            Console.WriteLine($"Produto B: \n Quantidade = {quantB} \n valor unitário = {valorProdB} \n Código = {codProdB}\n");
        }
        if (quantC != 0)
        {
            Console.WriteLine($"Produto C: \n Quantidade = {quantC} \n valor unitário = {valorProdC} \n Código = {codProdC}\n");
        }
        if (quantD != 0)
        {
            Console.WriteLine($"Produto D: \n Quantidade = {quantD} \n valor unitário = {valorProdD} \n Código = {codProdD}\n");
        }

        valorTotal = valorTotalA + valorTotalB + valorTotalC + valorTotalD;

        Console.WriteLine($"O valor total do carrinho é de: {valorTotal}");
    }
}
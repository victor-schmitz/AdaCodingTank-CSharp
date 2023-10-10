namespace Desafio04;

class Program
{
    static void Main()
    {
        float escolha, real, moedaConv;
        float dolarAmer = 5.5f;
        float euro = 6.5f;
        float libraEst = 6.3f;
        Boolean fecharProg= false;

        Console.OutputEncoding = System.Text.Encoding.UTF8; // Para usar o simbolo do Euro € 
        Console.WriteLine("Bem vindo ao Conversor de Moedas ADA!");

        while (!fecharProg) // While para rodar o programa até que o usuário decida fechar
        {
            Console.WriteLine("\nSeguem as moedas disponíveis para conversão:\n");
            Console.WriteLine("1 para Dolar Americano para Real (US$ 1.00 = R$ 5,50)");
            Console.WriteLine("2 para Euro (€ 1.00 = R$ 6,50)");
            Console.WriteLine("3 para Libra Esterlina (£ 1.00 = R$ 6,30)");
            Console.WriteLine("4 para fechar o programa\n");
            Console.Write("Digite qual moeda você quer converter para Real: ");
            
            if(!float.TryParse(Console.ReadLine(), out escolha) || escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4)
            {
                Console.WriteLine("Digite entre 1 e 4.");
            }
            else
            {
                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("\nVocê escolheu converter de Dolar Americano para Real.");
                        Console.Write("Digite quantos Reais você quer converter (apenas números): ");
                        float.TryParse(Console.ReadLine(), out real);

                        moedaConv = real / dolarAmer;

                        Console.WriteLine($"R$ {real:F2} é equivalente a US$ {moedaConv:F2}");
                        break;

                    case 2:
                        Console.WriteLine("\nVocê escolheu converter de Euro para Real.");
                        Console.Write("Digite quantos Reais você quer converter (apenas números): ");
                        float.TryParse(Console.ReadLine(), out real);

                        moedaConv = real / euro;

                        Console.WriteLine($"R$ {real:F2} é equivalente a € {moedaConv:F2}");
                        break;

                    case 3:
                        Console.WriteLine("\nVocê escolheu converter de Libra Esterlina para Real.");
                        Console.Write("Digite quantos Reais você quer converter (apenas números): ");
                        float.TryParse(Console.ReadLine(), out real);

                        moedaConv = real / libraEst;

                        Console.WriteLine($"R$ {real:F2} é equivalente a £ {moedaConv:F2}");
                        break;

                    case 4:
                        Console.WriteLine("\nObrigado por usar o Conversor de Moedas ADA!");
                        fecharProg = true;
                        break;                        
                }                
            }            
        }
    }
}

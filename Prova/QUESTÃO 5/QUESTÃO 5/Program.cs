//5 - Analise o código a seguir.

//for (int i = -5; i <= 7; i += 3)
//{
//    Console.WriteLine(i);
//}
//Assinale a opção que apresenta corretamente o resultado produzido pela execução do trecho acima. Justifique o porque dessa opção.

//A) –2, 1, 4, 7, 10

//B) –5, –2, 1, 4, 10

//C) –2, 1, 4, 7

//D) –5, –2, 1, 4

//E) –5, –2, 1, 4, 7

for (int i = -5; i <= 7; i += 3)
{
    Console.WriteLine(i);
}

// Respota certo = Letra //E) –5, –2, 1, 4, 7

// Ele vai iniciar o for com i = -5, rodando enquanto i for menor ou igual a 7, a cada iteração adicionando +3 em i
// Ele inicia com -5 na 1°
// Na segunda vira -5 + 3, que é -2
// na 3° vira -2 + 3, que é 1
// na 4° vira 1 + 3, que é 4 
// na 5° vira 4 + 3, que é 7, atingindo a condição de parada
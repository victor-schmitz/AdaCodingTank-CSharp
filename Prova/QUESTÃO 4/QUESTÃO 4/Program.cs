//4 - Ao executar o código a seguir será exibido qual valor no terminal? Justifique sua resposta.
//A) -1;

//B) 0;

//C) 1;

//D) 21;

//E) Irá dar erro

Int32 numero;
numero = Convert.ToInt16(!(21 > 21));
Console.WriteLine(numero);

// Resposta, LETRA C = 1

// Primeiro, declaramos uma variável inteira chamada numero. Logo depois, é dito que  numero vai ser igual a função Convert.ToInt16, que converte um booleano em inteiro de 16 bits. Dentro dos parenteses está a verificação do bool, que diz que 21 > 21, o que é falso. o ! inverte o valor do falso para true e o ToInt converte esse true para inteiro, que resulta em 1.
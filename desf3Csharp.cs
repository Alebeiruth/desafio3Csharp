// Inicializa um array de strings com duas strings diferentes.
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// Conta quantas strings estão no array.
int countString = myStrings.Length;

// Inicializa uma string vazia para armazenar a frase atual sendo processada.
string myString = "";

// Variável para armazenar a localização do ponto na frase.
int periodLocation = 0;

// Loop for para iterar por cada string no array.
for (int i = 0; i < countString; i++)
{
    // Atribui a string atual do array para 'myString'.
    myString = myStrings[i];
    
    // Encontra a primeira ocorrência de um ponto na string.
    periodLocation = myString.IndexOf(".");

    // Declaração de 'sentenceMy' para armazenar a frase atual.
    string sentenceMy;

    // Enquanto houver um ponto na string, o loop continua.
    while(periodLocation != -1)
    {
        // Remove tudo após o ponto para obter a frase atual.
        sentenceMy = myString.Remove(periodLocation);

        // Substring começa após o ponto para processar o restante da string.
        myString = myString.Substring(periodLocation + 1);

        // Remove espaços iniciais que podem ter sido deixados após a remoção da frase anterior.
        myString = myString.TrimStart();

        // Procura a próxima ocorrência de um ponto.
        periodLocation = myString.IndexOf(".");

        // Imprime a frase atual no console.
        Console.WriteLine(sentenceMy);
    }

    // Após o último ponto, pode haver uma frase sem ponto no final da string.
    // 'Trim' é usado para remover espaços em branco à esquerda e à direita.
    sentenceMy = myString.Trim();

    // Imprime a última frase que não terminava com um ponto.
    Console.WriteLine(sentenceMy);
}

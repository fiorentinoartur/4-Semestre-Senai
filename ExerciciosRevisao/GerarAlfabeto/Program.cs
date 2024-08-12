// Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
// letra do alfabeto aparece no texto.

Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine().ToLower();

// Dicionário para armazenar a contagem de cada letra
Dictionary<char, int> contagemLetras = new Dictionary<char, int>();

// Inicializa o dicionário com todas as letras do alfabeto
for (char c = 'a'; c <= 'z'; c++)
{
    contagemLetras[c] = 0;
}

// Contagem das letras no texto
foreach (char c in texto)
{
    if (char.IsLetter(c)) // Verifica se é uma letra
    {
        contagemLetras[c]++;
    }
}

// Exibe a contagem de cada letra
Console.WriteLine("Contagem de cada letra no texto:");
foreach (var item in contagemLetras)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}


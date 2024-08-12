// Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.

static void Tabuada(int num){

    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }
    
}

Tabuada(4);

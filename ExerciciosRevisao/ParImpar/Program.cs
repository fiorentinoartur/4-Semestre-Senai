// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
// número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.


Console.WriteLine("Bem vindo ao programa, por gentileza, informe um número inteiro: ");
int numUser = int.Parse(Console.ReadLine());

int varMod = numUser % 2;

Console.WriteLine(varMod);

if (numUser % 2 == 0)
{
    Console.WriteLine($"o número {numUser} é par!");
} else{
    Console.WriteLine($"o número {numUser} é impar");
}
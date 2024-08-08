// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número: ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{num} X {i} = {num * i}");
}


namespace Tentativa;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Seja bem vindo ao meu programa!");

        int contador = 1;
        int numUser;
        int numSortido = random.Next(1, 11);

        do
        {

            Console.WriteLine($"Digite um número de 1 a 10 para a {contador++}ª tentativa: ");
            numUser = int.Parse(Console.ReadLine());

        } while (numSortido != numUser);

        Console.WriteLine($"O número de tentativas finais foi de: {contador - 1}");
        System.Console.WriteLine($"O número sortido foi: {numSortido}");
    }
}

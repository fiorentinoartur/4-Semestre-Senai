namespace Tabuada;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número para tabuada: ");
        int numUser = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numUser} x {i} = {numUser * i}");
        }
    }
}

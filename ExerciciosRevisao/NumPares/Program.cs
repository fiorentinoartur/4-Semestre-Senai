namespace NumPares;

class Program
{
    static void Main(string[] args)
    {
        int numeros = 1;
        int soma = 0;

        while (numeros <= 100)
        {
            if (numeros % 2 == 0)
            {
                Console.WriteLine($"O número {numeros} é par");

                soma = soma + numeros;

                Console.WriteLine($"a soma final é: {soma}");
            }

            numeros++;
        }
    }
}
 
using System.Data;
using System.Runtime.Intrinsics.Arm;

Random random = new Random();
int numeroGerado = random.Next(1,11);
int? numeroDigitado = null;
int contador = 1;

do
{
    Console.WriteLine($"Digite um número aleatório, {contador}ª tentativa: ");
    numeroDigitado = int.Parse(Console.ReadLine()!); 
    

contador++;
} while (numeroGerado != numeroDigitado);


Console.WriteLine($"Número de tentativas: {contador - 1 } ");
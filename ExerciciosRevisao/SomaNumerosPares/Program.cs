// Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
// Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
// os números pares.


int[] numArrays = new int[] { 10, 20, 35, 2, 5, 19, 98, 1, 9, 7 };
int somaNum = 0;

for (int i = 0; i < numArrays.Length; i++)
{
    if (numArrays[i] % 2 == 0)
    {
        Console.WriteLine($"os números pares são: {numArrays[i]}");

        somaNum = numArrays[i] + somaNum;
    }
}
Console.WriteLine($"a soma final é: {somaNum}");

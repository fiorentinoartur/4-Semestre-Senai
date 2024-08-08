
int inicial = 1;
int somaFinal = 0;
int somaImpares = 0;


while (inicial <= 100)
{
    if (inicial % 2 == 0)
        somaFinal += inicial;
    else
        somaImpares += inicial;
    inicial++;
}
System.Console.WriteLine($"Soma dos números pares de 1 a 100: {somaFinal}");
System.Console.WriteLine($"Soma dos números impares de 1 a 100: {somaImpares}");

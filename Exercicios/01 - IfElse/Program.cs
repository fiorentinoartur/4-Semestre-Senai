
Console.WriteLine("Digite uma Nota: ");
double nota = Convert.ToDouble(Console.ReadLine()!);

if(nota > 7)
Console.WriteLine("Aluno Aprovado");
else if(nota >= 5)
Console.WriteLine("Aluno está em recuperação");
else
Console.WriteLine("Aluno está Reprovado");

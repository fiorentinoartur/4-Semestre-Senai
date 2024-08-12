namespace ExerciciosRevisao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a nota: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe seu nome: ");
        string nome = Console.ReadLine();

        if (nota > 7)
        {
            Console.WriteLine($"O aluno {nome} está aprovado");
        } else if(nota > 5) {
            Console.WriteLine($"O aluno {nome} está de recuperação");
        } else {
            Console.WriteLine($"O aluno {nome} está reprovado");
        }
    }
}

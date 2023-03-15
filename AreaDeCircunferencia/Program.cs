class Program
{
    static void Main(string[] args)
    {
        double PI = 3.1416;

        Console.WriteLine("Digite o valor do raio da circunferência: ");

        double raio = double.Parse(Console.ReadLine());

        double areaCircunferencia = PI * raio * raio;

        Console.WriteLine($"A área da circunferência é: {areaCircunferencia}");

    }
}
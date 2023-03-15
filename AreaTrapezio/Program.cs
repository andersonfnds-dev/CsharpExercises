double baseUm, baseDois, altura;

Console.WriteLine("Este programa irá calcular a área de um trapézio, " +
    "insira as seguintes informações: ");

Console.WriteLine("\nInsira o valor de uma base (em centimentros): ");
baseUm = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nInsira o valor de outra base (em centimentros): ");
baseDois = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nInsira o valor da altura (em centimentros): ");
altura = Convert.ToDouble(Console.ReadLine());

double areaTrapezio = ((baseUm + baseDois) * altura) / 2;

Console.WriteLine($"\nA área deste trapézio é: {areaTrapezio}cm");
Console.ReadKey();
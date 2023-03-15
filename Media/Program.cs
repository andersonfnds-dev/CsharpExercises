using System.Collections;

int numero;

Console.WriteLine("Este programa vai calcular a media de 3 numeros");

ArrayList numeros = new ArrayList();

while (numeros.Count != 3 )
{
    Console.WriteLine("Digite um numero");

    numero = Convert.ToInt16(Console.ReadLine());

    numeros.Add(numero);
}

int soma = 0;
foreach (int num in numeros)
{
    soma += num;
}

var media = soma / numeros.Count;

Console.WriteLine($"A média dos números digitados é: {media}");
Console.ReadKey();

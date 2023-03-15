using System.Collections;

string aluno;
double nota;
int numeroDeProvas;
ArrayList notas = new ArrayList(); ;

Console.WriteLine("Olá, qual é o seu nome? ");

aluno = Console.ReadLine();

Console.WriteLine($"\nOlá, {aluno} este programa irá calcular a sua média");

Console.WriteLine($"\nQuantas provas você teve neste semestre?");

numeroDeProvas = Convert.ToInt16(Console.ReadLine());

int indice = 1;
while ( notas.Count != numeroDeProvas)
{   

    Console.WriteLine($"\nDigite a sua {indice}° nota");
    
    nota = Convert.ToDouble(Console.ReadLine());

    notas.Add(nota);

    indice++;
}

double soma = 0;
foreach (double n in notas)
{
    soma += n;
}

double media = soma / notas.Count;
Math.Round(media, 1);

Console.WriteLine($"\nA média das suas notas é: {media}. ");

switch (media)
{
    case >= 9 and <= 10:
        Console.Write("Aprovado com menção SS");
        break;
    case >= 7 and < 9:
        Console.Write("Aprovado com menção MS");
        break;
    case >= 5 and < 7:
        Console.Write("Aprovado com menção MM");
        break;
    case >= 3 and < 5:
        Console.Write("Rerovado com menção MI");
        break;
    case > 0 and < 3:
        Console.Write("Reprovado com menção II");
        break;
    case 0:
        Console.Write("Reprovado com menção SR");
        break;
    default:   
        Console.WriteLine("Ocorreu algum erro, tente novamente");
        break;
}

Console.ReadKey();

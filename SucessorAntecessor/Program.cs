int numero;

Console.WriteLine("Digite um numero inteiro, te mostrarei o seu sucessor e antecessor!\n");

numero = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"\nO numero {numero} tem como sucessor {numero + 1} e como antecessor {numero - 1}.");

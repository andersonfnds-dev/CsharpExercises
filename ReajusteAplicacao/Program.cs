double saldo;
double ajuste = 1.1;

Console.WriteLine("Digite o saldo da sua aplicação, voltarei o mesmo reajustado em 1%\n");

saldo = Convert.ToDouble(Console.ReadLine());

double saldoConvertido = saldo * ajuste;

Console.WriteLine($"\nSeu saldo reajustado => {saldoConvertido}");
Console.ReadKey();

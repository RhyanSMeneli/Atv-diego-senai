// See https://aka.ms/new-console-template for more information
int numero;
Console.WriteLine("Insira um número");
numero = int.Parse(Console.ReadLine());
if (numero >= 1)
{
    Console.WriteLine($"O numero {numero} é positivo");
}
if (numero <= -1)
{
    Console.WriteLine($"o numero {numero} é negativo");
}
else if (numero == 0)
{
    Console.Write("Não é permitido zero");
}

int i = 1, n = 0, numero = 0, total = 0, negativo = 0, positivo = 0;

int i = 1, n = 0, numero = 0, total = 0, negativo = 0, positivo = 0;
Console.WriteLine("Quantas vezes deseja inserir o numero?");
n = int.Parse(Console.ReadLine()!);
while (n > i)
{
    Console.WriteLine("Escreva seu numero");
    numero = int.Parse(Console.ReadLine()!);

    if (numero > 0)
    {
        positivo++;
    }
    if (numero < 0)
    {
        negativo++;
    }
    if (numero == 0)
    {

    }
    i++;
}
Console.WriteLine($"Você tem {negativo} numeros negativos e {positivo} numero positivos,");



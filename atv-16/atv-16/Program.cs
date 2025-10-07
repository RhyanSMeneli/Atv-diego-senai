int n1 = 0, n2 = 0, n3 = 0, n4 = 0, i = 0;

Console.WriteLine("Digite um número:");
n1 = int.Parse(Console.ReadLine()!);
i = n1 - 1;
n3 = n1;
if (n1 < 0)
{
    Console.WriteLine("Inexistente!");
}
if (n1 == 0)
{
    Console.WriteLine("Por definição é 1");
}
else if (n1 > 0)
{
    while (i > 0)
    {

        n3 = n3 * i;
        i--;


    }



    Console.WriteLine($"O fatorial de {n1} é {n3}");
}


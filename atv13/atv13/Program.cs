int n1, n2, n3;
    Console.WriteLine("Digite o primeiro numero:");
n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro numero:");
    n3 = int.Parse(Console.ReadLine());

        if (n1 <= n2 && n1 <= n3)
{
     if (n2 <= n3)
     {
        Console.WriteLine(n1 + " " + n2 + " " + n3);
     }
        if (n3 <= n2)
     {
        Console.WriteLine(n1 + " " + n3 + " " + n2);
     }
}

    if (n2 <= n1 && n2 <= n3 && n2 != n1)
{
        if (n1 <= n3)
    {
        Console.WriteLine(n2 + " " + n1 + " " + n3);
    }
        if (n3 <= n1)
    {
        Console.WriteLine(n2 + " " + n3 + " " + n1);
    }
}

    if (n3 <= n1 && n3 <= n2 && n3 != n1 && n3 != n2)
{
        if (n1 <= n2)
    {
        Console.WriteLine(n3 + " " + n1 + " " + n2);
    }
        if (n2 <= n1)
    {
        Console.WriteLine(n3 + " " + n2 + " " + n1);
    }
}


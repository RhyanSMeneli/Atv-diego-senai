// See https://aka.ms/new-console-template for more information
int n1, n2, totall;
Console.WriteLine("Digite a 1° nota:");
    n1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Digite a 2° nota:");
    n2 = int.Parse(Console.ReadLine()!);
totall = (n1 + n2) / 2;
        if ( totall >= 6) {

    Console.WriteLine("aprovado");

}
if (totall < 6)
{
    Console.WriteLine("Reprovado");
}




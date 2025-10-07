int num1 = 0, num2 = 0, media = 0;
Console.WriteLine("Escreva um numero.");
num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Escreva outro numero.");
num2 = int.Parse(Console.ReadLine()!);
media = (num2 + num1) % 2;
if (media % 2 == 0)
{
    Console.WriteLine("Seu numero é par");

}
if (media % 2 == 1)
{
    Console.WriteLine("Seu numero e impar");
}
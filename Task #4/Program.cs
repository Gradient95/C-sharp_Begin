// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число A - ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B - ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число C - ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
if (max < numberC)
{
    max = numberC;
}
Console.Write(max);

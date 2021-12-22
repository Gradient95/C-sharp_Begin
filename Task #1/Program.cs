// See https://aka.ms/new-console-template for more information
Console.Write("Введите число А => ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B => ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Является ли число A квадратом числа B?");
if (numberA == numberB * numberB)
{
    Console.Write("Верно!");
}
else
{
    Console.Write("Неверно!");
}
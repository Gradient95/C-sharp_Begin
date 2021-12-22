// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число нижнего диапазона - ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число верхнего диапазона - ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("Неверный ввод");
}
else while (numberA <= numberB)
    {
        Console.Write("  " + numberA);
        numberA = numberA + 1;
    }

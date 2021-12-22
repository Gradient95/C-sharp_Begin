// See https://aka.ms/new-console-template for more information
Console.Write("Введите последнее число диапазона => ");
int X = int.Parse(Console.ReadLine());
int i = 0;
while (i < X)
{
    i++;
    if (i % 2 == 0)
    {
        Console.Write("{0} ", i);
    }
}
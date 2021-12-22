// See https://aka.ms/new-console-template for more information
Console.Write("Введите число A - ");
double numberA = double.Parse (Console.ReadLine());
Console.Write("Введите число B - ");
double numberB = double.Parse (Console.ReadLine());
if  (numberA > numberB)
{
    Console.Write("numberA>numberB");
}
else  if (numberA == numberB)
{
    Console.Write("numberA=numberB");
}
else 
{
    Console.Write("numberB>numberA");
}

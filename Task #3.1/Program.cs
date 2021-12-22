// See https://aka.ms/new-console-template for more information
string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.Write("Введите номер дня недели - ");
int number = int.Parse(Console.ReadLine());
if (number > 7)
{
    Console.Write("Неправильно введен номер");
}
else
    Console.Write(array[number - 1]);
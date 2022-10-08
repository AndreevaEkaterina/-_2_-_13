// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите число от 0 до 99999:");
int num = int.Parse(Console.ReadLine()!);
if (num < 100000 && num > -1)
{
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else if (num > 100 && num < 1000)
    {
        int a = num % 10;
        Console.WriteLine($"{num}->{a}");
    }
    else if (num > 1000 && num < 10000)
    {
        int a = (num % 100) / 10;
        Console.WriteLine($"{num}->{a}");
    }
    else
    {
        int a = (num % 1000) / 100;
        Console.WriteLine($"{num}->{a}");
    }
}
else
{
    Console.WriteLine("Некорректное число.");
}
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6

int Third(int n)
{
    while (n > 999 || n < -999)
    {
        n = n / 10;
    }
    int result = n % 10;
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    int third = Third(number);
    Console.WriteLine(third);
}
else
{
    if (number < -99)
    {
        int third = Third(number);
        Console.WriteLine(Math.Abs(third));
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }
}

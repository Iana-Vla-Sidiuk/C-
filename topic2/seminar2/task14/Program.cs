// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void result(int numberA)
{
    if ((numberA % 7 == 0) & (numberA % 23 == 0))
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
result(number);




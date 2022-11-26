// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
//Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно



void result(int c1, int c2)
{
    if (c1 % c2 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        int mod = c1 % c2;
        Console.WriteLine($"Не кратно, остаток {mod}");
    }
}

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 == 0)
{
    Console.WriteLine("Делить на ноль нельзя!");
}
else
{
    if (number1 < number2)
    {
        Console.WriteLine("Первое число должно быть больше второго!");
    }
    else
    {
        result(number1, number2);
    }
}




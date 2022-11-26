// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number < 6)
{
    Console.WriteLine("нет");
}
else
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("Некорректное значение! Введите число от 1 до 7!");
    }
}
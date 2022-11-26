// See https://aka.ms/new-console-template for more information
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int even = 2;
if (N < 2)
{
    Console.WriteLine("Введите корректное число > 1");
}
else
{
    while ((even < N) || (even == N))
    {
        Console.WriteLine(even);
        even = even + 2;
    }
}
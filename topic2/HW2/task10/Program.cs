﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int second = (number % 100) / 10;
    Console.WriteLine(second);
}
else
{
    Console.WriteLine("Некорректное значение! Необходимо ввести трехзначное число!");
}

// Задача 1
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
 if (Number % 7 == 0 || Number % 23 ==0)
     Console.WriteLine("да");
 else
     Console.WriteLine($"нет, {Number % 7 == 0 || Number % 23 ==0}");


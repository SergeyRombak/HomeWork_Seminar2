// Задача3
/* Напишите программу, которая принимает на вход целое число
из отрезка [10, 99] и показывает наибольшую цифру числа.*/

Console.Clear();
Console.Write("Введите число от 10 до 99: ");
int number = int.Parse(Console.ReadLine()!);
while (number < 10 || number > 99)
{
    Console.Write("Ошибка!\nВведите число от 10 до 99: ");
    number = int.Parse(Console.ReadLine()!);
}
int firstNumber = number / 10;
int secondNumber = number % 10;
if (firstNumber > secondNumber)
{
    Console.WriteLine("Наибольшая цифра: " + firstNumber);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + secondNumber);
}

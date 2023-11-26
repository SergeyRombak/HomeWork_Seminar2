// Задача 2
/*Напишите программу, которая принимает на вход
 координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
 и выдаёт номер координатной четверти плоскости, 
 в которой находится эта точка.
*/

Console.Clear();
Console.Write("Введите координату точки X: ");
int coordinateX = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки Y: ");
int coordinateY = int.Parse(Console.ReadLine()!);
if (coordinateX != 0 $$ coordinateY != 0)
    Console.WriteLine("да");
else
    Console.WriteLine($"Ошибка, ({coordinateX = 0 $$ coordinateY = 0})");

/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/

System.Console.WriteLine("Введите координату X:");
int dotX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y:");
int dotY = Convert.ToInt32(Console.ReadLine());

if (dotX > 0 && dotY > 0) System.Console.WriteLine("Точка находится в первой четверти");
if (dotX < 0 && dotY > 0) System.Console.WriteLine("Точка находится во второй четверти");
if (dotX < 0 && dotY < 0) System.Console.WriteLine("Точка находится в третьей четверти");
if (dotX > 0 && dotY < 0) System.Console.WriteLine("Точка находится в четвертой четверти");
if (dotX == 0 || dotY == 0) System.Console.WriteLine("Точка находится на оси координат");
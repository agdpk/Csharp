/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double TakeEntNum(string message){
      System.Console.WriteLine(message);
      double result = Convert.ToDouble(Console.ReadLine());
      return result;
}

double b1 = TakeEntNum("Введите значение b1: ");
double k1 = TakeEntNum("Введите значение k1: ");
double b2 = TakeEntNum("Введите значение b2: ");
double k2 = TakeEntNum("Введите значение k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения прямых находится в координатах: x={x}; y={y}]");
/*
Напишите программу, которая принимает два числа и проверяет является одно число квдратом второго
*/

System.Console.WriteLine("Введите число 1:");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2:");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 / userNumber2 == userNumber2 || userNumber2 / userNumber1 == userNumber1) 
System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");
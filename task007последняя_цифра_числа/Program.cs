/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
*/

System.Console.WriteLine("Введите число:");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int result = userNumber1 % 10;
System.Console.WriteLine(result);
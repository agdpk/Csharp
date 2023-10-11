/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторуб цифру этого числа
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int last = number % 10;

System.Console.WriteLine($"{first}{last}");
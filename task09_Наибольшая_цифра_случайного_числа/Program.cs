/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int first = number / 10;
int last = number % 10;

if (first > last) System.Console.WriteLine("наибольшая " + first);
else System.Console.WriteLine("наибольшая " + last);
/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе кратным первому. Если втрое число некратно первому, то программа выводит остаток от деления.
*/

System.Console.WriteLine("Введите число 1:");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2:");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 % userNumber2 == 0) System.Console.WriteLine("Кратно");
else System.Console.WriteLine("Некратно, остаток от деления: " + userNumber1 % userNumber2);
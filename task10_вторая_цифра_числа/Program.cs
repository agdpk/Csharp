/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000){
    int secondNumber = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра {secondNumber}");
}
else System.Console.WriteLine("Введено не трехзначное число");
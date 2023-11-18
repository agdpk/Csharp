/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


System.Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int intN(int numberM, int numberN)
{
    int sum = 0;
    if (numberM <= numberN) sum += numberM + intN(numberM + 1, numberN);

    return sum;
}

int sum = intN(numberM, numberN);
System.Console.WriteLine($"Сумма натуральных элементов: {sum}");
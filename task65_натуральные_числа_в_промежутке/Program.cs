/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/

System.Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void intN(int numberM, int numberN)
{
if (numberN >= numberM)
{
System.Console.Write(numberM + " ");
intN(numberM + 1, numberN);
}
else
return;
}

intN(numberM, numberN);
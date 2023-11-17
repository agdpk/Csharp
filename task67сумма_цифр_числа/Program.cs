/*
67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfInt(int number){
    if (number / 10 != 0){
        number = number % 10 + SumOfInt(number / 10);
    }
    return number;
}

int sum = SumOfInt(number);
System.Console.WriteLine(sum);
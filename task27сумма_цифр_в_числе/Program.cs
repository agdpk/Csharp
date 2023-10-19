/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


void SumOfNumbers(int a){
    int sum = 0;
    for (int i = a; i > 0; i/=10)
    {
        sum += i % 10;
    }
    System.Console.WriteLine(sum);
}

System.Console.Write("Введите число : ");
int userA = Convert.ToInt32(Console.ReadLine());
SumOfNumbers(userA);
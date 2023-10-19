/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

void AmountOfNumbers (int a){
    int count = 0;
    for(int i = a; i > 0; i /= 10){
        count++;
    }
    System.Console.WriteLine(count);
} 

System.Console.Write("Введите число A:");
int userA = Convert.ToInt32(Console.ReadLine());
AmountOfNumbers(userA);
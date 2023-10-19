/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/


void Sum (int a){
    int result = 0;
    for(int i = 1; i <= a; i++){
        result = result + i;
    }
    System.Console.WriteLine(result);
}


System.Console.Write("Введите число A:");
int userA = Convert.ToInt32(Console.ReadLine());
Sum(userA);
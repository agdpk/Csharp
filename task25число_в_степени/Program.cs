/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void Power(int a, int b){
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    System.Console.WriteLine(result);
}

System.Console.Write("Введите число A:");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B:");
int userB = Convert.ToInt32(Console.ReadLine());
Power(userA, userB);
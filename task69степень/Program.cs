/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

System.Console.WriteLine("Введите число : ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int MulA(int n, int n2){
    if (n2 > 1){
        n = n * MulA(n, n2 - 1);
    }
    return n;
}

int result = MulA(numberA, numberB);
System.Console.WriteLine(result);
/*
 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

void MultNumber(int a){
    int result = 1;
    for (int i = 1; i <= a; i++){
        result = result * i;
    }
    System.Console.WriteLine(result);
}

System.Console.Write("Введите число N:");
int userN = Convert.ToInt32(Console.ReadLine());
MultNumber(userN);
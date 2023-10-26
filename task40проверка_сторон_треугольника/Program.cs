/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
*/

int TakeEntNum(string message){
      System.Console.Write(message);
      int result = Convert.ToInt32(Console.ReadLine());
      return result;
}

bool IsTriangle(int a, int b, int c){
    if(a + b > c && b + c > a && c + a > b){
        return true;
    }
    return false;
}

int userA = TakeEntNum("Введите число a: ");
int userB = TakeEntNum("Введите число b: ");
int userC = TakeEntNum("Введите число c: ");

System.Console.WriteLine(IsTriangle(userA, userB, userC));
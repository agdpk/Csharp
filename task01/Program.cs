/*
Напишите программу, которая принимает два числа и проверяет, является ли первое число квадратом второго
*/
System.Console.WriteLine("Введите число 1: "); 
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2: "); 
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if(userNumber1 == userNumber2 * userNumber2){
    System.Console.WriteLine($"Да первое число: {userNumber1} квадрат второго: {userNumber2}");
}
else{
    System.Console.WriteLine($"Нет первое число: {userNumber1} не квадрат второго: {userNumber2}");
}
﻿/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int[] FibonachiNumbers(int number){
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++){
        array[i] = array[i - 2] + array[i - 1];
    } 
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int TakeEntNum(string message){
      System.Console.Write(message);
      int result = Convert.ToInt32(Console.ReadLine());
      return result;
}

int userNumber = TakeEntNum("Введите число: ");

PrintArray(FibonachiNumbers(userNumber));
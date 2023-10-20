/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetRandomArray(int start, int end, int size){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(start, end + 1);
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
      System.Console.WriteLine(message);
      int result = Convert.ToInt32(Console.ReadLine());
      return result;
}

int AmountOfNumber(int[] arr, int dStart, int dEnd){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= dEnd && arr[i] >= dStart){
            count++;
        }
    }
    return count;
    
}

int userStart = TakeEntNum("Начало элементов");
int userEnd = TakeEntNum("Конец элементов");
int userSize = TakeEntNum("Размер массива");
int userDStart = TakeEntNum("Начало диапозона");
int userDEnd = TakeEntNum("Конец диапозона");

int[] userArray = GetRandomArray(userStart, userEnd, userSize);
PrintArray(userArray);
System.Console.WriteLine("");

System.Console.WriteLine($"Количество {AmountOfNumber(userArray, userDStart, userDEnd)}");
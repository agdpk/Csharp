/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
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

int SumOddElements(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0){
            sum += arr[i];
        }
    }
    return sum;
}

int userStart = TakeEntNum("Начало элементов");
int userEnd = TakeEntNum("Конец элементов");
int userSize = TakeEntNum("Размер массива");

int[] userArray = GetRandomArray(userStart, userEnd, userSize);
PrintArray(userArray);
System.Console.WriteLine("");

int sumOdd = SumOddElements(userArray);
Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
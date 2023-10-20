/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] GetRandomArray(int start, int end){
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++){
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

void SumOfPosNumbers(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) {
            sum += arr[i];
        }
    }
    System.Console.WriteLine($"Сумма положительных чисел массива: {sum}");
}

void SumOfNegNumbers(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) {
            sum += arr[i];
        }
    }
    System.Console.WriteLine($"Сумма отрицательных чисел массива: {sum}");
}

System.Console.Write("Введите start:");
int userstart = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите end:");
int userend = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRandomArray(userstart, userend);
PrintArray(userArray);
System.Console.WriteLine("");
SumOfPosNumbers(userArray);
SumOfNegNumbers(userArray);


//int TakeEntNum(string message){
//      System.Console.WriteLine(message);
//      int result = Convert.ToInt32(Console.ReadLine());
//      return result;
//}
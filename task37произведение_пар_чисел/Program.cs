/*
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] ProductArray(int[] arr){
    int[] newArray = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return newArray;
}

int userStart = TakeEntNum("Начало элементов");
int userEnd = TakeEntNum("Конец элементов");
int userSize = TakeEntNum("Размер массива");

int[] userArray = GetRandomArray(userStart, userEnd, userSize);
PrintArray(userArray);
System.Console.WriteLine("");
PrintArray(ProductArray(userArray));
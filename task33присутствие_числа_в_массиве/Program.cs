/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

bool IsNumber(int[] arr, int number){
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == number){
                return true;
            }
        }
        return false;
}

int userStart = TakeEntNum("Начало элементов");
int userEnd = TakeEntNum("Конец элементов");
int userSize = TakeEntNum("Размер массива");
int userNumber = TakeEntNum("Искамое число");

int[] userArray = GetRandomArray(userStart, userEnd, userSize);
PrintArray(userArray);
System.Console.WriteLine("");

if (IsNumber(userArray, userNumber)){
    System.Console.WriteLine("да");
}
else System.Console.WriteLine("нет");
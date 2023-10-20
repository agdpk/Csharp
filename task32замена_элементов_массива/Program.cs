/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

int[] SwitchNumbers(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int userStart = TakeEntNum("Начало элементов");
int userEnd = TakeEntNum("Конец элементов");
int userSize = TakeEntNum("Размер массива");

int[] userArray = GetRandomArray(userStart, userEnd, userSize);
PrintArray(userArray);
System.Console.WriteLine("");
int[] switchedArray = SwitchNumbers(userArray);
PrintArray(switchedArray);
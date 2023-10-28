/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] GetRandom2DArray(int m, int n, int start, int end){
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

int TakeEntNum(string message){
      System.Console.Write(message);
      int result = Convert.ToInt32(Console.ReadLine());
      return result;
}

void Print2DArray(int[,] array){
    Console.Write($"[ ]\t");
    int start = 0;
    for (int i = start; i < start + array.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void SumOfMainDiagonalElements(int[,] array){
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        sum += array[i,i];
    }
    System.Console.WriteLine(sum);
}

int userStart = TakeEntNum("Начало элементов: ");
int userEnd = TakeEntNum("Конец элементов: ");
int userM = TakeEntNum("Введите количество строк: ");
int userN = TakeEntNum("Введитеколичество столбцов: ");

int[,] userArray = GetRandom2DArray(userM, userN, userStart, userEnd);
Print2DArray(userArray);
SumOfMainDiagonalElements(userArray);


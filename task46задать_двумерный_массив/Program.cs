/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


int userStart = TakeEntNum("Начало элементов: ");
int userEnd = TakeEntNum("Конец элементов: ");
int userM = TakeEntNum("Введите количество строк: ");
int userN = TakeEntNum("Введитеколичество столбцов: ");

int[,] userArray = GetRandom2DArray(userM, userN, userStart, userEnd);
Print2DArray(userArray);

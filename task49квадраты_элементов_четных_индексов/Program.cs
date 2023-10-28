/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

int[,] SquareOfEvenElements(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0){
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}

int userStart = TakeEntNum("Начало элементов: ");
int userEnd = TakeEntNum("Конец элементов: ");
int userM = TakeEntNum("Введите количество строк: ");
int userN = TakeEntNum("Введитеколичество столбцов: ");

int[,] userArray = GetRandom2DArray(userM, userN, userStart, userEnd);
Print2DArray(userArray);
System.Console.WriteLine();
int[,] changedArray = SquareOfEvenElements(userArray);
Print2DArray(changedArray);
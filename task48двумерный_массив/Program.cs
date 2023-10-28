/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
*/


int[,] GetRandom2DArray(int m, int n){
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
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



int userM = TakeEntNum("Введите количество строк: ");
int userN = TakeEntNum("Введитеколичество столбцов: ");

int[,] userArray = GetRandom2DArray(userM, userN);
Print2DArray(userArray);

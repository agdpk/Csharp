/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
*/

void ConvertNumber(int number){
    int convertedNumber = 0;
    int temp = 0;
    for(int i = number; i > 0; i /= 2){
        temp = i % 2;
        convertedNumber = convertedNumber * 10 + temp; 
    }
    System.Console.WriteLine(convertedNumber);
}

int TakeEntNum(string message){
      System.Console.Write(message);
      int result = Convert.ToInt32(Console.ReadLine());
      return result;
}

int userNumber = TakeEntNum("Введите число: ");
ConvertNumber(userNumber);
/*
Программа на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
*/

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++){
        if (i % 2 == 0){
          Console.Write(i + "\t");
        }
}
/*
Программа на вход принимает два числа и выводит, какое число большее, а какое меньшее.
*/

System.Console.WriteLine("Введите число 1:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число 2:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber){
          Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        else if (firstNumber < secondNumber) {
          Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
        else {
          Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }

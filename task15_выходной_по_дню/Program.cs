/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

bool ValidateWeekday(int number){
    if (number > 0 && number <= 7){
        return true;
    }
    System.Console.WriteLine("Не день недели");
    return false;
}

bool IsWeekend(int number){
    if (number > 5){
        return true;
    }
    return false;
}

if (ValidateWeekday(number)){
    if (IsWeekend(number)){
        System.Console.WriteLine("Выходной");
    }
    else {
        System.Console.WriteLine("Будний день");
    }
}
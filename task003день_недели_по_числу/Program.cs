/*
Программа, выдающая день недели по введенному числу
*/
System.Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) System.Console.WriteLine("Сегодня понедельник");
if (day == 2) System.Console.WriteLine("Сегодня вторник");
if (day == 3) System.Console.WriteLine("Сегодня среда");
if (day == 4) System.Console.WriteLine("Сегодня четверг");
if (day == 5) System.Console.WriteLine("Сегодня пятница");
if (day == 6) System.Console.WriteLine("Сегодня суббота");
if (day == 7) System.Console.WriteLine("Сегодня воскресенье");
else System.Console.WriteLine("Нет такого дня недели");
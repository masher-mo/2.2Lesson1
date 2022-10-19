// Программа, при вводе числа должна выводить соответствующему числу день недели.


Console.Write("Введите пожалуйста число: ");
string userNumber = Console.ReadLine();
int dayNumber = int.Parse(userNumber);
if (dayNumber == 1) Console.WriteLine("Понедельник");
if (dayNumber == 2) Console.WriteLine("Вторник");
if (dayNumber == 3) Console.WriteLine("Среда");
if (dayNumber == 4) Console.WriteLine("Четверг");
if (dayNumber == 5) Console.WriteLine("Пятница");
if (dayNumber == 6) Console.WriteLine("Суббота");
if (dayNumber == 7) Console.WriteLine("Воскресенье");

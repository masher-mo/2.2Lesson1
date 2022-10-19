// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9 , b = 3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Введите 2 числа:");
string numberAStr = Console.ReadLine();
string numberBStr = Console.ReadLine();
int numberA = int.Parse(numberAStr);
int numberB = Convert.ToInt32(numberBStr);
int kvadrat = numberB * numberB;
if(kvadrat == numberA)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else
{
    Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
}
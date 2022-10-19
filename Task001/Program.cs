// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное н само себя).

// Например:
// 4 -> 16
// 3 -> 9
// 7 -> 49

Console.WriteLine("Введите число, у которого хотите получить квадрат:");
string numberStr = Console.ReadLine();// то, что вводит пользователь с консоли, всегда тип string.
int number = int.Parse(numberStr);
int result = number * number;

Console.WriteLine($"Квадрат числа {number} равен {result}");
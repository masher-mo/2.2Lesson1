//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//  918 -> 8

Console.WriteLine("Введите 3хзначное число: ");
string numberA = Console.ReadLine();
int number = int.Parse(numberA);
if (number >= 100 && number <=999)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра 3хзначного числа {result}");
}
else
{
    Console.WriteLine("Данные не верные ");
}
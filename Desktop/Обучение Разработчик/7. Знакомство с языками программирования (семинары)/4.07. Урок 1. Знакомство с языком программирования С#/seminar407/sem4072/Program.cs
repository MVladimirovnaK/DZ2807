// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
int numberA = new Random().Next(1, 100);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);

if (numberA == numberB * numberB)

{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
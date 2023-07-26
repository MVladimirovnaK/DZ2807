// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int numA = new Random().Next(1,100);
Console.WriteLine($"Первая сторона треугольника равна {numA}");

int numB = new Random().Next(1,100);
Console.WriteLine($"Вторая сторона треугольника равна {numB}");

int numC = new Random().Next(1,100);
Console.WriteLine($"Третья сторона треугольника равна {numC}");

if(numA + numB > numC && numA + numC > numB && numB +numC > numA)
{
    Console.WriteLine($"Треугольник со сторонами, равными {numA}, {numB}, {numC} может существовать.");
}
else
{
    Console.WriteLine($"Треугольник со сторонами, равными {numA}, {numB}, {numC} не может существовать.");
}
// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int size = 6;
int[] numbers = new int[size];
Random rnd = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(-9, 9);
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

int halfSize = numbers.Length/2;   // halfsize - середина, проходим массив с двух сторон сразу, поэтому делим длину на 2
int lastIndex = numbers.Length-1;  // ластиндекс - это последний индекс (длина минус 1, тк индексы начинаютс с 0)
for (int i = 0; i < halfSize; i++)
{
    int temp = numbers[i]; // создаем 3-ю переменную и в нее кладем значение, временное хранилище
    numbers[i] = numbers[lastIndex - i]; // перекладываем в последнюю ячейку
    numbers[lastIndex - i] = temp; // значение из последней ячейки перезаписываем во временное хранилище темп
    // или кортеж (numbers[i], numbers[lastIndex - i]) = (numbers[lastIndex - i], numbers[i]);
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

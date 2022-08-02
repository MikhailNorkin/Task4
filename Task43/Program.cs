/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
Console.Write($"Введите размер массива:");

int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

int i = 0;
while (i < size)
{
    Console.Write($"Введите [{i}] элемент:");
    array[i] = int.Parse(Console.ReadLine());
    i++;
}

for(int j = 0; j < size; j++)
    Console.Write($"{array[j]} ");

Console.Write("-> [");

for(int j = 0; j < size-1; j++)
    Console.Write($"{array[j]}, ");

Console.Write($"{array[size-1]}] ");
Console.WriteLine();
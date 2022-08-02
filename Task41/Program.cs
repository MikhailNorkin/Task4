/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


void function()
{
    int a = 0;
    int b = 0;
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    Console.Write($"{a} , {b} -> ");
    int res = 1;
    for(int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    Console.Write($" {res}");
    Console.WriteLine();
    return;

}

Console.WriteLine($"Введите два числа: ");
function();
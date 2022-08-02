/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

void function(int a)
{
    Console.Write($"{a} -> ");
    int res = 0;
    for(int i = 0; i < a; i++)
    {
        res = res + a%10;
        a = a/10; 
    }
    Console.WriteLine($" {res}");
    return;
}

Console.Write($"Введите число: ");
function(int.Parse(Console.ReadLine()));
﻿// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
    Console.Write(array[i] + " ");

    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine();
Console.Write("Количество чётных числе в массиве " + count);
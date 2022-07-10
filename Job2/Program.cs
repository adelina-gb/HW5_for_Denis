﻿/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void Task36()
{
    int size = 4;
    int[] array = new int[size];
    FillArray(array,10,50);
    PrintArray(array);
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях равна " + SumElementsNegativeIndex(array));
    Console.WriteLine();
}

int SumElementsNegativeIndex(int [] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i%2 == 1) sum += array[i];
    }
    return sum;
}

void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

Task36();



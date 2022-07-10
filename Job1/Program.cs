/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void Task34()
{
    int size = 8;
    int[] array = new int [size];
    FillArray(array, 100, 1000);
    PrintArray(array);
    CountPositiveNumber(array);    
}

void CountPositiveNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) 
        count++;
    }
    Console.WriteLine("Количество чётных чисел в массиве: " + count);

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
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] +"\t");
    }
    Console.WriteLine();
}

Task34();
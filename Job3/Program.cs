/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void Task38()
{
    int size = 8;
    double[] array = new double[size];
    DoubleFillArray(array, -100, 1001);
    DoublePrintArray(array);
    Console.WriteLine("Максимальное число в массиве: " + MaxNumber(array));
    Console.WriteLine("Минимальное число в массиве: " + MinNumber(array));
    Console.WriteLine($"Разница между максимальным и минимальным элементами в массиве:  {MaxNumber(array) - MinNumber(array)}");
}

double MaxNumber(double[] array)
{
    double max = array[0];    
    for(int i = 0; i < array.Length; i++)
    {
        
        if(array[i] > max ) max = array[i];
    }
    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];    
    for(int i = 0; i < array.Length; i++)
    {
        
        if(array[i] < min ) min = array[i];
    }
    return min;
}


void DoubleFillArray(double [] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber)*0.1;
    }
}

void DoublePrintArray(double[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}
Task38();
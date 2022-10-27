// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);
         
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void Diff(double[] array)
{
    double maxarr = array[0];
    double minarr = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxarr) maxarr = array[i];
        if (array[i] < minarr) minarr = array[i];
        array[i] = Math.Round(maxarr, 2);
        array[i] = Math.Round(minarr, 2);
    }
    Console.WriteLine($"Максимальное значение = {maxarr}, минимальное значение = {minarr}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {maxarr - minarr}");
}

double[] arr = CreateArrayRndDouble(5, 1, 100);
PrintArrayDouble(arr);
Diff(arr);

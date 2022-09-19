// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArrey(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

double GetMaxNumber(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber)
        {
            maxNumber = arr[i];
        }
    }
    return maxNumber;
}

double GetMinNumber(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNumber)
        {
            minNumber = arr[i];
        }
    }
    return minNumber;
}


double[] array = FillArrey(10);
Console.WriteLine("Вывод массива:");
PrintArray(array);
Console.WriteLine(" ");
double max = GetMaxNumber(array);
double min = GetMinNumber(array);
Console.WriteLine($"Разница между максимальным элементом {max} и минимальным {min} составляет {max-min}");

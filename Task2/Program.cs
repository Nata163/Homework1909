// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int size, int startNumber, int endNumber)
{
    int[] array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, endNumber + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i > 0 && i % 2 > 0)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

int[] array = FillArray(10, 1, 99);
Console.WriteLine("Вывод массива:");
PrintArray(array);
Console.WriteLine(" ");
int result = GetSum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {result}");
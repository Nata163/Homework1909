// Найдите произведение пар чисел в одномерном массиве. Парой считается первый и посл элемент, второй и предпосл и тд.
// Результат запишите в новый массив

int[] TakeArray(int[] arr)
{
    if (arr.Length % 2 == 0)
    {
        int[] array = new int[arr.Length / 2];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = arr[i] * arr[arr.Length - (i + 1)];
        }
        return array;
    }
    else
    {
        int[] array = new int[arr.Length / 2 + 1];
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                array[i] = arr[i];
            }
            else array[i] = arr[i] * arr[arr.Length - (i + 1)];
        }
        return array;
    }

}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int[] array = { 1, 2, 3, 4, 5 };
int[] newArray = TakeArray(array);
PrintArray(newArray);
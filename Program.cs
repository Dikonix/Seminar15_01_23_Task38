int[] CreateRandomArray(int sizeArray, int start, int end)
{
    int[] randomArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        randomArray[i] = new Random().Next(start, end);
    }
    return randomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int MaxNumber(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int MinNumber(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int[] array = CreateRandomArray(6, 0, 100);
ShowArray(array);

int max = MaxNumber(array);
int min = MinNumber(array);
int difference = max - min;

Console.WriteLine($"Разница между {max} и {min} равна {difference}");

// Считывание ввода числа
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Заполнение массива случайными числами от мин до макс включительно
int[] FillArrayRandom(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

// Печать массива
void PrintArray(int[] array)
{
    int i = 0;
    Console.Write($"{array.Length} -> [");
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[i]}]");
}

// Убрать из массива какое-то значение
int[] RemoveFromArrayNumber(int[] array, int removeNumber)
{
    int i = 0;
    int[] arrayNew = new int[array.Length - 1];
    int removePosIndex = IndexOf(array, removeNumber);
    for (i = 0; i < arrayNew.Length; i++)
    {
        if (i >= removePosIndex)
            arrayNew[i] = array[i + 1];
        else
            arrayNew[i] = array[i];
    }
    return arrayNew;
}

// Найти в массиве индекс желаемого элемента
int IndexOf(int[] array, int find)
{
    int i = 0;
    int position = -1;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] == find)
        {
            position = i;
            break;
        }
    }
    return position;
}

// Перемешать массив случайным образом
int[] ShuffleArray(int[] array)
{
    int[] tempArray = array;
    int[] numbersMixed = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int randomIndex = new Random().Next(0, tempArray.Length);
        numbersMixed[i] = tempArray[randomIndex];
        tempArray = RemoveFromArrayNumber(tempArray, numbersMixed[i]);
    }
    return numbersMixed;
}
// Задача 29: Напишите программу, которая задаёт массив 
// из 8 случайных целых чисел и выводит отсортированный по модулю массив.

// -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
// 6, 1, -33 -> [1, 6, -33]

int[] array = new int[8];

Console.Clear();
Console.WriteLine("************************************************************");
Console.WriteLine("Дан массив случайных чисел:");

MakeArray(array);
PrintArray(array);

Console.WriteLine("Сортируем массив по модулю:");

SortArray(array);
PrintArray(array);

void MakeArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(-99, 100);
    }
}

void PrintArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} \t");
    }
    Console.WriteLine("");
}

void SortArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < currentArray.Length; j++)
        {
            if (Math.Abs(currentArray[j]) < Math.Abs(currentArray[minPos])) minPos = j;
        }
        int temp = currentArray[i];
        currentArray[i] = currentArray[minPos];
        currentArray[minPos] = temp;
    }
}

Console.WriteLine("************************************************************");
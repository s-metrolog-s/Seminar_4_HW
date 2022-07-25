// Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. 
// Определите самый часто встречающийся элемент в массиве. 
// Если таких элементов несколько, вывести их все.

int[] randomArray = new int[100];
int[,] tempArray = new int[2, randomArray.Length];

Console.Clear();
Console.WriteLine("****************************************************************************");
Console.WriteLine("Дан массив, заполненный случайными числами:");
Console.WriteLine("****************************************************************************");

MakeArray(randomArray);
PrintArray(randomArray);
SortArray(randomArray);
// Console.WriteLine();
// PrintArray(randomArray);

FindEquals(randomArray, tempArray);

// PrintMatrix(tempArray);
Console.WriteLine("****************************************************************************");
Console.WriteLine("Ищем одинаковые элементы массива...");

PrintRepeatNumbers(tempArray, FindMaxEl(tempArray));

Console.WriteLine("****************************************************************************");

// Описание методов

void MakeArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(1, 100);
    }
}

void PrintArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        if ((i + 1) % 10 == 1) Console.WriteLine();
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

void FindEquals(int[] currentArray, int[,] matrix)
{
    int index = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        int maxValue = currentArray[i];
        int count = 1;

        for (int j = i + 1; j < currentArray.Length; j++)
        {
            if (currentArray[i] == currentArray[j])
            {
                count++;
            }
        }
        tempArray[0, index] = maxValue;
        tempArray[1, index] = count;
        index++;
    }
}

void PrintMatrix(int[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortArray (int[] currentArray)
{
    for (int i = 0; i < currentArray.Length - 1; i++)
    {
        for (int j = i + 1; j < currentArray.Length; j++)
        {
            if (currentArray[i] > currentArray[j])
            {
            int temp = currentArray[i];
            currentArray[i] = currentArray[j];
            currentArray[j] = temp;
            }
        }
    }
}

int FindMaxEl (int[,] currentMatrix)
{
    int maxRepeatNumber = currentMatrix[1, 0];
    for (int j = 0; j < currentMatrix.GetLength(1); j++)
    {
        if (currentMatrix[1, j] > maxRepeatNumber) maxRepeatNumber = currentMatrix[1, j]; 
    }
    return maxRepeatNumber;
}

void PrintRepeatNumbers (int[,] currentMatrix, int maxRepeatNumber)
{
    for (int j = 0; j < currentMatrix.GetLength(1); j++)
    {
        if (currentMatrix[1, j] == maxRepeatNumber)
        {
            Console.WriteLine("Число " + currentMatrix[0, j] + " встречается в массиве " + currentMatrix[1, j] + " раз(-a)");
        }
    }
}
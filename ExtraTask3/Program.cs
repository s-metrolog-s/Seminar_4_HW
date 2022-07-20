// Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. 
// Определите самый часто встречающийся элемент в массиве. 
// Если таких элементов несколько, вывести их все.

int[] randomArray = new int[50];
int[] tempArray = new int[randomArray.Length/2];

Console.Clear();
Console.WriteLine("****************************************************************************");
Console.WriteLine("Дан массив, заполненный случайными числами:");
Console.WriteLine("****************************************************************************");

MakeArray(randomArray);
PrintArray(randomArray);
Console.WriteLine("****************************************************************************");

FindEquals(randomArray, tempArray);

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

void FindEquals(int[] currentArray, int[] tempArray)
{
    int maxValue = currentArray[0];
    int maxCount = 0;
    int value = currentArray[0];

    for (int i = 0; i < currentArray.Length; i++)
    {
        int count = 0;

            for (int j = 0; j < currentArray.Length; j++)
            {
                if (currentArray[i] == currentArray[j])
                {
                    value = currentArray[i];
                    count++;
                }
            }

            if (count > 2) Console.WriteLine($"{value} встречается {count} раз");
            
            if (count > maxCount) 
            {
                maxValue = currentArray[i];
                maxCount = count;
            }
    }
    Console.WriteLine($"Большее количество раз встречается число {maxValue} с {maxCount}");
}

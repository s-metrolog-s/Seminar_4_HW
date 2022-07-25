// Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. 
// Размер массива должен совпадать с квадратом количества единиц в нём.

Random rand = new Random();
int numberOnes = rand.Next(1, 50);
int length = numberOnes * numberOnes;
int[] currentArray = new int[length];
int[] currentArray2 = new int[length];

Console.Clear();
Console.WriteLine("***************************************************************************");
Console.WriteLine("Дано количество единиц " + numberOnes);
Console.WriteLine("Длина массива " + length);
Console.WriteLine("**************************************************************************");

FillArray(currentArray, numberOnes);
FillArrayMath(currentArray2, numberOnes);

Console.WriteLine("Заполняем случайно, пока есть единицы:");
PrintArray(currentArray);

Console.WriteLine();
Console.WriteLine("***************************************************************************");

Console.WriteLine("Количество единиц случайно, заполнение по алгоритму:");
PrintArray(currentArray2);

Console.WriteLine();
Console.WriteLine("***************************************************************************");

void FillArray (int[] currentArray, int number1)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (number1 > 0)
        {
            currentArray[i] = rand.Next(0, 2);
            if (currentArray[i] == 1) number1--;
        }
        else currentArray[i] = 0;
    }
}

void PrintArray (int[] currentArray)
{
    for (int i =0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
        if (((i + 1) % 10 == 0) && i > 1) Console.WriteLine();
    }
}

void FillArrayMath (int[] currentArray, int number)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (i % number == 0) currentArray[i] = 1;
        else currentArray[i] = 0;
    }
}
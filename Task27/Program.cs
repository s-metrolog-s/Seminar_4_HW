// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("*******************************************");
/* Если задаем числа случайно, ипользуем эту конструкцию
Random rand = new Random();
int N = rand.Next(-100, 1000);
Console.WriteLine($"Дано число N равное: {N}");
*/
Console.WriteLine("Введите любое число:");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));


int count = CountNumbers(N); // Для подсчета количества знаков в числе
int sum = 0; // Для вычисления суммы чисел

int[] array = new int[count];

MakeArray(array, N);

for (int i = 0; i < count; i++)
{
    sum = sum + array[i];
}

Console.WriteLine($"Сумма чисел {N} равна {sum}");

void MakeArray(int[] currentArray, int value)
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        currentArray[i] = value % 10;
        value = value / 10;
    }
}

int CountNumbers(int number)
{
    int count = 0;
    while (number > 0)
    {
    number = number / 10;
    count++;
    }
    return count;
}

Console.WriteLine("*******************************************");
// Задача 25: Напишите цикл, который принимает на вход 
// два натуральных числа (A и B) и возводит число A в степень B.

// 3, 5 -> 243
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Рассчитаем результат возведения случайных чисел A в степень B");

LevelUp();
LevelUp();
LevelUp();

void LevelUp()
{
    Random rand = new Random();

    double number1 = rand.Next(1, 10);
    double number2 = rand.Next(1, 10);
    double result = number1;
    int count = 1;
    while (count < number2)
    {
        result = result * number1;
        count++;
    }

    Console.WriteLine($"{number1} в степени {number2} -> {result}");
}

Console.WriteLine("********************************************************");
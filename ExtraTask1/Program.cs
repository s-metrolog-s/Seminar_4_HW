// Задача 1. На вход подаётся натуральное десятичное число. 
// Проверьте, является ли оно палиндромом в двоичной записи.

Random rand = new Random();
int number1 = 17;
int number2 = 15;
int number3 = rand.Next(0, 257);

Console.Clear();
Console.WriteLine("******************************************");
Console.WriteLine($"Даны следующие числа {number1}, {number2}, {number3}");
Console.WriteLine("В двоичной системе будут представлено как:");

Console.Write($"{number1} -> ");
CheckPalindrom(MakeStringFromNumber(number1));
Console.Write($"{number2} -> ");
CheckPalindrom(MakeStringFromNumber(number2));
Console.Write($"{number3} -> ");
CheckPalindrom(MakeStringFromNumber(number3));

Console.WriteLine("******************************************");

string MakeStringFromNumber (int number)
{
    string valueToString = String.Empty;
    for (int i = 0; number > 0; i++)
    {
        if (number % 2 == 1) valueToString = "1" + valueToString;
        else valueToString = "0" + valueToString;
        number /= 2;
    }
    return valueToString;
}

void CheckPalindrom (string number)
{
    int count = number.Length - 1;
    bool flag = true;
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] != number[count])
        {
            flag = false;
            break;
        }
        count--;
    }
    if (flag) Console.WriteLine($"{number} -> является палиндромом");
    else Console.WriteLine($"{number} -> не является палиндромом");
}


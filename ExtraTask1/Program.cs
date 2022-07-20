// Задача 1. На вход подаётся натуральное десятичное число. 
// Проверьте, является ли оно палиндромом в двоичной записи.

Console.Clear();
Console.WriteLine("*************************************");
int number = 10;
int[] array = new int[];

Console.WriteLine(MakeDualFromTen(number));

string MakeDualFromTen(int number)
{
    string numberDual = string.Empty;
    for (int i = 0; number > 0; i++)
    {
        numberDual[i] = Convert.ToString(number % 2);
        number = number / 2;
    }
    return numberDual;
}

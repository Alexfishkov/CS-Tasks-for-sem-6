// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное (без использования рекурсии).
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int[] binary = new int[100];
int n = 0, temp = 0;

Console.Clear();
Console.WriteLine("Преобразуем введённое вами десятичное целое число в двоичное");
Console.Write("Введите ваше число=> ");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 0) Console.WriteLine("00");
else if (number == 1) Console.WriteLine("01");
else
{

    while (number >= 1)
    {
        binary[n] = number % 2;
        number = number / 2;
        n++;
    }

    for (int i = 0; i < n / 2; i++)
    {
        temp = binary[i];
        binary[i] = binary[n - 1 - i];
        binary[n - 1 - i] = temp;
    }

    for (int i = 0; i < n; i++)
    {
        Console.Write(binary[i]);
    }
}
Console.WriteLine();




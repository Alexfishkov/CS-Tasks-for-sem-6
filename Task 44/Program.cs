// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

long firstnumber = 0L, secondnumber = 1L, result = 0L;
int n = 0;

Console.Clear();
Console.WriteLine("Выводим последовательность чисел Фибоначчи до заданного вами N");
Console.WriteLine("Введите целое число N больше 0, но не более 93 => ");
n = Convert.ToInt16(Console.ReadLine());

if (n >= 1)
{

    if (n == 1) Console.WriteLine($"F(1) = 0");
    else if (n == 2)
    {
        Console.WriteLine($"F(1) = 0");
        Console.WriteLine($"F(2) = 1");
    }
    else
    {

        Console.WriteLine($"F(1) = 0");
        Console.WriteLine($"F(2) = 1");

        for (int i = 3; i <= n; i++)
        {
            result = firstnumber + secondnumber;
            firstnumber = secondnumber;
            secondnumber = result;
            Console.WriteLine($"F({i}) = {result}");
        }
    }
}
else Console.WriteLine("Ввод был некорректным, перезапустите программу и выполните коррректный ввод!");

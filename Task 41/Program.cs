// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();
Console.WriteLine("Компьютер посчитает,сколько из введённых вами чисел больше 0. Что бы закончить ввод - наберите stop");
string answer = "";
int amount = 0;

do
{
    Console.WriteLine("Введите новое число=>");
    answer = Console.ReadLine();
    answer = answer.ToLower();
    if (answer == "stop") break;
    if (double.TryParse(answer, out double number))
    {
        if (number > 0) amount++;
    }
    else Console.WriteLine("Некорректный ввод. Введите число, либо stop");
} while (true);

if (amount > 0) Console.WriteLine($"Из введённых вами чисел {amount} больше нуля");
else Console.WriteLine($"вы не ввели ни одного числа больше нуля");


        


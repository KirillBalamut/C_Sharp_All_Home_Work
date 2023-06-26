/*Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Write("Введите трехзначное число >");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000)
{
    Console.Write("Вы ввели неправильное число, повторите ввод :");
    return;
}

Console.WriteLine($"введите трехзначное число'{number}' ");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра числа '{secondRank}'");

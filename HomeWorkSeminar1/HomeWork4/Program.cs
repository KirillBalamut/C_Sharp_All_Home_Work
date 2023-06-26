/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.WriteLine(" Привет, данная программа показывает все чётные числа от 1 до N");
Console.Write("Введи число N = ");
int number = Convert.ToInt32(Console.ReadLine());
int numbers = 2;

if (number > 1)
{
    while (numbers <= number)
    {
        Console.Write(numbers + " ");
        numbers = numbers + 2;
    }
}
/* Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначнон число: ");
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else Console.WriteLine($"Вы Ввели НЕправильное число");
*/

Console.Write(" Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int b = 0;
int c = number;

if (number <= 9999 || number > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число!");
    Environment.Exit(0);
}
while (number != 0)
{
    b = (b * 10) + (number % 10);
    number = number / 10;
}
if (c == b)
{
    Console.WriteLine("Данное число является палидромом ! ");
}
else
{
    Console.WriteLine("Данное число НЕ является палидромом ! ");
}
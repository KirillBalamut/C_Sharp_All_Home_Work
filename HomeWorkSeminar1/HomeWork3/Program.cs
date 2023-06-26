/*Напишите программу, которая на вход принимает число и выдаёт, является 
ли число чётным (делится ли оно на два без остатка).*/
Console.WriteLine(" Привет, данная программа для определения четных чисел");
Console.Write("Введи число = ");
double number = Convert.ToDouble(Console.ReadLine()); ;
double honest = number % 2;

if (honest == 0)
{
    Console.WriteLine($"число {number} четное");
}
else
{
    Console.WriteLine($"число {number} не четное");
}

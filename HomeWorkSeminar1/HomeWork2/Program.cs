//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("первое число = ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("второе число = ");
double number2 = Convert.ToDouble(Console.ReadLine());
Console.Write("третье число = ");
double number3 = Convert.ToDouble(Console.ReadLine());
var max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное из чисел {number1}, {number2}, {number3} равно {max}");

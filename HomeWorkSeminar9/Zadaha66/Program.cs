﻿/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();
Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
/*
int UserRequest(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
*/
int SummNumber(int m, int n)
{
    if (m == n) return m;
    if (m > n) return SummNumber(m - 1, n) + m;
    else return SummNumber(m + 1, n) + m;
}
/*
int m = UserRequest("Задайте значение M: ");
int n = UserRequest("Задайте значение N: ");
*/
Console.WriteLine(SummNumber(m, n));


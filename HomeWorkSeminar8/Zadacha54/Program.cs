/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
const int row = 5;
const int col = 5;

int[,] array = new int[5, 5];
Console.WriteLine("Исходный массив : ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}

Console.WriteLine("упорядоченный массив на увеличение: ");

for (int i = 0; i < row; i++)
{
    var stack = new Stack<int>();

    for (int j = 0; j < col - 1; j++)
        for (int k = j + 1; k < col; k++)
        {
            if (array[i, k] < array[i, j])
            {
                stack.Push(array[i, k]);
                array[i, k] = array[i, j];
                array[i, j] = stack.Pop();
            }
        }
}

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
        Console.Write(array[i, j].ToString() + ' ');
    Console.WriteLine("");
}
Console.WriteLine("упорядоченный массив на уменьшение : ");

for (int i = 0; i < row; i++)
{
    var stack = new Stack<int>();

    for (int j = 0; j < col + 1; j++)
        for (int k = j + 1; k < col; k++)
        {
            if (array[i, k] > array[i, j])
            {
                stack.Push(array[i, k]);
                array[i, k] = array[i, j];
                array[i, j] = stack.Pop();
            }
        }
}

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
        Console.Write(array[i, j].ToString() + ' ');
    Console.WriteLine("");
}
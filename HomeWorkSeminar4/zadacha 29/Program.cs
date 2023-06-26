/* 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/


int[] array = new int[8];

Console.Write("Исходный массив :  ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    Console.Write(array[i] + " ");
}
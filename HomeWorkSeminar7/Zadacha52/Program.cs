/*Задача 52. Задайте двумерный массив из целых чисел
Найдите среднее арифметическое элементов в каждом столбце 
Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 100);
            Console.Write(randomArray[i, j] + " \t ");
        }
        Console.WriteLine();
    }
}

void arif(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i, j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i, j];
        }
        Console.Write($"{sum / (i):F1}; ");
    }
}
mas(m, n);
arif(m, n);
*/
int[,] array = new int[5, 5];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 5);
        Console.Write(array[i, j] + " ");

    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    double sum = 0;
    double avResult = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    avResult = sum / array.GetLength(1);
    Console.WriteLine($" среднее арифметическое {i}; {avResult}");
}
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/
double[] arrayRealNumbers = new double[20];
for (int i = 0; i < arrayRealNumbers.Length; i++)    /*цикл выполняется до тех пор пока переменная i не будет
 больше или равна длинне массива*/
{
    arrayRealNumbers[i] = Math.Round((new Random().NextDouble() * new Random().Next(0, 10)), 2);   // NextDouble генерирует число от 0 до 1, перемножает 
                                                                                                   //на рандомное число в диапазоне от 0 до 10

    //Next (указываем в каком промежутке чисел)
    Console.Write(arrayRealNumbers[i] + " ");      // выводим наш массив ( arrayRealNumbers[i] - переменная хранящая массив 
    // + " " (пробел))
}

double maxNumber = arrayRealNumbers[0]; //переменная максимального значения массива = переменной массива
double minNumber = arrayRealNumbers[0];  // переменная минимального значения массива 

for (int i = 1; i < arrayRealNumbers.Length; i++)   // идем по массиву перебирая значения
{
    if (maxNumber < arrayRealNumbers[i])       // поиск максимального элемента массива
    {     // если maxNumber меньше переменной массива то хаписываем в переменную maxNumber
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])       //  поиск минимального элемента массива
    {     // если minNumber больше переменной массива то записываем в переменную minNumber
        minNumber = arrayRealNumbers[i];
    }
}

double decision = maxNumber - minNumber;        // находим разницу между значениями массива

Console.WriteLine($"\n разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
/*Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int tempNumber = number;
while (tempNumber != 0)
{
    int endDigit = tempNumber % 10;
    sum = sum + endDigit;
    tempNumber = tempNumber / 10;
}
Console.WriteLine($"Сумма цифр в числе {number} = {sum}");

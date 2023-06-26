/* Напишите программу, которая принимает на вод число (N)
 и выдаёт таблицу кубов чисел от 1 до N */
/*Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube)
{
    int count = 0;
    int length = cube.Length;
    while (count < length)
    {
        cube[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}
int[] arry = new int[cube + 1];
Cube(arry);
PrintArry(arry);
Console.WriteLine(" Введите число :");
int number = int.Parse(Console.ReadLine());
int j = 0;
while (j <= number)
{
    Console.WriteLine(j * j);
    j++;

}
*/
Console.WriteLine(" Введите число :");
double number = Convert.ToInt32(Console.ReadLine());
double j = 0;
while (j <= number)
{
    Console.WriteLine(Math.Pow((j), 3));
    j++;
}
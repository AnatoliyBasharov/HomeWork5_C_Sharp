// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = new double[5];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0, 100) + rnd.NextDouble();
}
void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write("\t" + item);
    }
}
PrintArray(array);
double MaxAndMinNumber(double[] array)
{
    double Max = 0;
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (Max < array[i])
        {
            Max = array[i];
        }
        if (Min > array[i])
        {
            Min = array[i];
        }
    }
    System.Console.WriteLine("\n Max " + Max);
    System.Console.WriteLine("\n Min " + Min);
    return Max - Min;
}
System.Console.WriteLine($"\n ===> {MaxAndMinNumber(array)}");


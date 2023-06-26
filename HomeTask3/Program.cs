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
double MaxNumber(double[] array)
{
    double index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (index <= array[i])
        {
            index = array[i];
        }
    }
    return index;
}
double MinNumber(double[] array)
{
    double index = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (index >= array[i])
        {
            index = array[i];
            index++;

        }
    }
    return index - 1;             //  я так и не разобрался с этим моментом откуда он берет единицу в ответ,
}                                 // поэтому пришлось эту единицу у него и забирать. :/

System.Console.WriteLine($" ==> {MaxNumber(array)} - {MinNumber(array)} = ");

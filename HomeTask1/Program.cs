// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GenerateArray(int Len, int min, int max)
{
    int[] Randarray = new int[Len];
    Random rnd = new Random();
    for (int i = 0; i < Randarray.Length; i++)
    {
        Randarray[i] = rnd.Next(min, max + 1);
    }
    return Randarray;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write("\t" + item);
    }
}

int[] ReadArray = GenerateArray(6, 100, 999);
PrintArray(ReadArray);
int PositiveNumber(int[] array)
{
    int temp = 0;
    for (int i = 0; i < ReadArray.Length; i++)
    {
        if (ReadArray[i] % 2 == 0)
        {
            temp++;
        }
    }
    return temp;
}
System.Console.WriteLine($" -->  {PositiveNumber(ReadArray)}");



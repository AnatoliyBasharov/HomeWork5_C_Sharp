// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Generate(int Len, int min, int max)
{
    int[] arrayrnd = new int[Len];
    Random rnd = new Random();
    for (int i = 0; i < arrayrnd.Length; i++)
    {
        arrayrnd[i] = rnd.Next(min, max + 1);
    }
    return arrayrnd;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write("\t" + item);
    }
}
int[] array = Generate(6, -20, 20);
PrintArray(array);
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        i++;                                          //Если считать как программисты то i++ выше суммы,                                                        
        sum += array[i];                                    //если как обычные люди то i++ ниже суммы
        
    }
    return sum;
}
System.Console.WriteLine($" --> {SumArray(array)}");
//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива. 
int m = 4;
int n = 5;
int[,] array2 = new int[m, n];
FillArray2(array2);
PrintArray2(array2);
Console.WriteLine();
SortMaxtoMin(array2);
Console.WriteLine();
PrintArray2(array2);
void FillArray2(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(1, 10);
}
void PrintArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
}

void SortMaxtoMin(int[,] array)
{
    for (int i = 0; i < array.GetLongLength(0); i++)
    {
        for (int j = 0; j < array.GetLongLength(1) - 1; j++)
        {
            while (array[i, j] < array[i, j + 1])
            {
                int item = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = item;
                j = 0;
            }
        }
    }
}


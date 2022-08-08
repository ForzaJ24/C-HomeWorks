//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

int m = 3;
int n = 4;

int[,] array2 = new int[m, n];

FillArray2(array2);

PrintArray2(array2);
Console.WriteLine();

FindSringAVG(array2);
Console.WriteLine();
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

void FindSringAVG(int[,] array)
{
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < min)
            min = sum;
    }
    Console.WriteLine($"Min string summ is {min}");
}

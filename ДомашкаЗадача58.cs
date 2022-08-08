// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
int m = 2;
int n = 2;
int[,] array = new int[m, n];
int[,] array2 = new int[m, n];
FillArray(array);
FillArray(array2);

PrintArray(array);
Console.WriteLine();

PrintArray(array2);
Console.WriteLine();

Multiplication(array, array2);
void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(1, 10);
}
void PrintArray(int[,] array)
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

void Multiplication(int[,] array, int[,] array2)
{
    int[,] array3 = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array3[i, j] = 0;
            array3[i, j] = array[i, j] * array2[i, j];
            Console.Write($"{array3[i, j]} ");
        }
        Console.WriteLine("");
    }
}

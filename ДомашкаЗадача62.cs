//Заполните спирально массив 4 на 4.
int m = 4;
int n = 4;
int[,] array = new int[m, n];
SpiralFill(array);
PrintArray(array);
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = 0;
}
void SpiralFill(int[,] array)
{
    int count = 1;

    for (int d = 0; d < array.GetLength(0) - 2; d++)
    {
        for (int j = 0 + d; j < array.GetLength(1) - d; j++)
        {
            array[0 + d, j] = count++;
        }
        count--;
        for (int i = 0 + d; i < array.GetLength(0) - d; i++)
        {
            array[i, array.GetLength(0) - 1 - d] = count++;
        }
        count--;
        for (int j = array.GetLength(1) - 1 - d; j >= 0 + d; j--)
        {
            array[array.GetLength(1) - 1 - d, j] = count++;
        }
        count--;
        for (int i = array.GetLength(0) - 1 - d; i >= 1 + d; i--)
        {
            array[i, 0 + d] = count++;
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine("");
    }
}
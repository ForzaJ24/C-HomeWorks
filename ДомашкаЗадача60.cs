//Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Числа выбираются случайно, 
//при этом проверяется, что такого числа еще не было. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

int m = 3;
int n = 3;
int l = 3;

int[,,] array2 = new int[m, n, l];
int[] arrayUnq = new int[m * n * l];

FillUnic(arrayUnq);
FillArray2(array2);

PrintArray2(array2);
Console.WriteLine();

PrintUNIC(arrayUnq);
Console.WriteLine();
Console.WriteLine();
FillArrayUNIC(array2, arrayUnq);
PrintArray2(array2);
void FillArray2(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = 0;
            }
        }
    }
}
void PrintArray2(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"i = [{i}{j}{k}] = {array[i, j, k]}. ");
            }
        }
        Console.WriteLine("");
    }
}
void FillUnic(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0);)
    {
        bool CheckInHere = false;
        int item = rnd.Next(10, 99);
        for (int j = 0; j < i; j++)
        {
            if (array[j] == item)
            {
                CheckInHere = true;
            }
        }
        if (!CheckInHere)
        {
            array[i] = item;
            i++;
        }
    }
}
void PrintUNIC(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]}. ");
    }
}

void FillArrayUNIC(int[,,] array, int[] array2)
{
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = array2[l++];
            }
        }
    }
}
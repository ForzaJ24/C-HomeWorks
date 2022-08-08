//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
//чётных чисел в массиве. 
//Длина массива задается с терминала.
int [] numbers = new int[8];
Console.Write("Random massive is : [");

int Method (int a)
{
    return numbers[a];
}

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next();
    Console.Write(" " + Method (i) + ",");
 }

 // не понял как убрать запятую после i[9]
 // видимо, не там гуглил...

Console.Write("]");
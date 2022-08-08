//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество
//чётных чисел в массиве. 
//Длина массива задается с терминала.
Console.WriteLine("Enter length of massive : ");

int m = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int[m];
int count = 0;

for (int i = 0; i < numbers.Length; i++)

 {

    numbers [i] = new Random().Next(100,999);
    if (i/2==1) 
         count++;

 }
Console.Write("Count even digits in massive is :"+ count );



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 

Console.WriteLine("введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int B = Convert.ToInt32(Console.ReadLine());

int step = A;

for (int i = 1; i < B; i++)
{
step = step * A;
}
Console.WriteLine("A в степени B = " + step);

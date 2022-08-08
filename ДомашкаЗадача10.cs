// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Hello! Enter third digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
    Console.WriteLine("Error!Enter correct number!");
if (number > 999)
    Console.WriteLine("Error!Enter correct number!");
else
{
    number = number / 10;

    number = number % 10;
    Console.WriteLine("Second number is: " + number);
}

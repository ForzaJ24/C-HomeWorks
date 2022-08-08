// Напишите программу, которая выводит третью цифру слева 
// заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Please, enter number: ");
int ThirdDigit = Convert.ToInt32(Console.ReadLine());
if (ThirdDigit < 100)
    Console.WriteLine("Third digit is no exist.");
else
{
    while (ThirdDigit > 999)

        ThirdDigit = ThirdDigit / 10;

    ThirdDigit = ThirdDigit % 10;
    Console.WriteLine("Third digit is: " + ThirdDigit);
}
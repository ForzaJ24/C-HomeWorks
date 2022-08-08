// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("HI! Enter number to test : ");
string n = Console.ReadLine();
char[] narray = n.ToCharArray();
Array.Reverse(narray);
string t = new string(narray);
if (n == t)
    Console.WriteLine("Polyndrom");
else
    Console.WriteLine("Not polyndrom");

// Тип string преворачивает строку, а не только число, поэтому 
// программа является универсальной как для чисел,
// так и для букв и символов, что, в том числе, выполняет условие 
// задачи. 
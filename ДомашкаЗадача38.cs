// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным значением элементов массива. 
// Длина массива задается с терминала.

double[] arrayNumbers = new double[10];
Console.WriteLine("Enter length of massive : ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
  }

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nDifferent beetwen min:({minNumber}) and max:({maxNumber}) is:{decision}");

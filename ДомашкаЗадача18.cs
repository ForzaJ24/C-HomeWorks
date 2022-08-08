// Определить диапазон точек по номеру квадрата

Console.WriteLine("Enter number of quadrant: ");
int quadrant=Convert.ToInt32(Console.ReadLine());
if (quadrant == 1)
Console.WriteLine(" Quadrant 1 : x>0,y>0. ");
else if (quadrant == 2)
    Console.WriteLine("Quadrant 2 : x<0,y<0 ");
else if (quadrant == 3)
    Console.WriteLine("Quadrant 3 : x>0,y<0 ");
else if (quadrant==4)
    Console.WriteLine("Quadrant 1 : x<0,y>0 ");
else
    Console.WriteLine("Quadrant is no exist! Enter correct number!");
      return;

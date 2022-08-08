// Программа принимает на вход номер дня недели,
// определяет выходной ли это.
Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>0 & n<6)
        Console.WriteLine("No. Go to work!");
else if (n>5 & n<8 )
     Console.WriteLine("Yes! Its hollyday!");
else 
    Console.WriteLine("You wrong! Enter correct day number!");
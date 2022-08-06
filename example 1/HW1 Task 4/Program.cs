
Console.WriteLine("Введеите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введеите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введеите 3 число");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(number1);
    }
    else
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(number3);
    }
}
  else
    {
        if (number2 > number3)
        {
            Console.Write("Максимальное число: ");
            Console.WriteLine(number2);
        }
        else
        {
            Console.Write("Максимальное число: ");
            Console.WriteLine(number3);
        }
    }


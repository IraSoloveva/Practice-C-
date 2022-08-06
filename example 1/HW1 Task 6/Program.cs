

Console.WriteLine("Введеите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введеите 2 число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Большее число:");
    Console.WriteLine(number1);
    Console.Write("Меньшее число:");
    Console.WriteLine(number2);
}
else
{
    Console.Write("Большее число:");
    Console.WriteLine(number2);
    Console.Write("Меньшее число:");
    Console.WriteLine(number1);
}


while (true)
{
    Console.WriteLine("Введите оператор");
    String Operator = Console.ReadLine();
    if (Operator == "end")
    {
        break;
    }
    Console.WriteLine("Введеите 1 число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введеите 2 число");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (Operator == "+")
    {
        Console.WriteLine(number1 + number2);
    }
    else if (Operator == "-")
    {
        Console.WriteLine(number1 - number2);
    }
    else if (Operator == "*")
    {
        Console.WriteLine(number1 * number2);
    }
    else if (Operator == "/")
    {
        Console.WriteLine(number1 / number2);
    }

}















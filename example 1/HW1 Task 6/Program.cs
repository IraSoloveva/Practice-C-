
Console.WriteLine("Введеите число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    
    int number2 =2;
    int r = (number1 % number2);

    if (r == 0)
    {
        Console.WriteLine("Да");

    }
    else 
    {
         Console.WriteLine("Нет");
    }

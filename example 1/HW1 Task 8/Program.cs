


Console.WriteLine("Введеите число");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = 2;
int count = 1;

while (count < number1 + 1)
{
    int r = (count % number2);

    if (r == 0)
    {
        Console.Write(count);
    }
  count = count +1;
}

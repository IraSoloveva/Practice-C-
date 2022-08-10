using System;

class Programm
{
    static void WriteSelect(string[] namesArray)
    {
        for (int i = 0; i < namesArray.Length - 1; i++)
        {
            Console.Write(i + 1 + " - " + namesArray[i] + ", ");
        }
        Console.WriteLine(namesArray.Length + " - " + namesArray[namesArray.Length - 1] + ". ");
    }
    static void SelectRaсe()
    {
        string[] namesRace = { "Люди", "Эльфы", "Гномы", "Орки" };
        WriteSelect(namesRace);
        System.Console.WriteLine("Укажите Вашу расу");
        int IndexRace = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Ваша раса " + namesRace[IndexRace - 1]);
    }
    static void SelectClass()
    {
        string[] namesClass = { "Воин", "Маг", "Вор", "Врач" };
        WriteSelect(namesClass);
        System.Console.WriteLine("Укажите Ваш класс");
        int IndexRace = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Ваш класс " + namesClass[IndexRace - 1]);
    }
    static void SelectGender()
    {
        string[] namesGender = { "Мужской", "Женский" };
        WriteSelect(namesGender);
        System.Console.WriteLine("Укажите Ваш пол");
        int IndexRace = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Ваш пол " + namesGender[IndexRace - 1]);
    }

    static void Main(string[] args)
    {
        SelectRaсe();
        SelectClass();
        SelectGender();
    }
}

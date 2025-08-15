using System;
public class Progrm
{
    static void Main()
    {
        Console.WriteLine("Hello Buddy");
        Console.Write("what is your name");
        string name = Console.ReadLine();

        Console.Write("How old are you");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"{name} is {age} year  old");

        if (age < 18)
        {
            Console.WriteLine("You are a student");
        }
        else
        {
            Console.WriteLine("You are an adult");
        }
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine("ki");
        }
        switch (age)
        {
            case 18:
                Console.WriteLine("You are 18 years old");
                break;
            case 21:
                Console.WriteLine("You are 21 years old");
                break;
            default:
                Console.WriteLine("You are some age year old");
                break;
        }
        for (int i = 0; i < 5; i++)
        {
            if ( i==1)
            {
                continue;
            }
            else if (i==4)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}

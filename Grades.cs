using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string percentage = Console.ReadLine();

        int x = int.Parse(percentage);

        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >=  80)
        {
            letter = "B";
        }
        else if (x >=  70)
        {
            letter = "C";
            
        }
        else if (x >=  60)
        {
            letter = "D";
        }
        else if (x <  60)
        {
            letter = "F";
        }

        Console.Write($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.Write("Congratulations! You passed the class!");
        }
        else
        {
            Console.Write("We are sorry, but you failed this class. Work a little harder, and you can do it next time!");
        }
    }
}
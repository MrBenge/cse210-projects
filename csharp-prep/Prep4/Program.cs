using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number (enter 0 when you are done): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int Sum = 0;

        foreach (int number in numbers)
        {
            Sum += number;
        }

        Console.WriteLine($"The sum of the list is {Sum}");

        float Average = ((float)Sum) / numbers.Count;
        Console.WriteLine($"The average of the list is {Average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The largest number is {max}");
    }
}
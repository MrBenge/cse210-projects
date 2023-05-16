using System;

class Program
{
    static void Main(string[] args)
    {

        Options option1 = new Options();
        option1._introduction = "Please select one of the following choices";
        option1._first = "Write";
        option1._second = "Display";
        option1._third = "Load";
        option1._fourth = "Save";
        option1._fifth = "Quit";

        option1.Display();

        string firstResponse = "-1";


        Journal journal = new Journal();

        do
        {
            Console.WriteLine("What would you like to do?");
            string firstResponse = Console.ReadLine();

            if (firstResponse == "1")
            {
                journal.Write();
            }
            else if (firstResponse == "2")
            {
                journal.DisplayIt();
            }
            else if (firstResponse == "3")
            {
                journal.Load();
            }
            else if (firstResponse == "4")
            {
                journal.Save();
            }
            while (firstResponse != "5");
    }
}
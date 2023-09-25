using System;

class Program
{
    static void Main(string[] args)
    {
        // Journal theJournal = new Journal();
        // Entry anEntry = new Entry();
        // anEntry.Display();

        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        string ask = Console.ReadLine();

        while (ask != "5")
        {
            if (ask == "1")
            {
                // display random prompt
                // get input
                break;
            }

            else if (ask == "2")
            {
                // Date: displayDate - Prompt: displayPrompt
                // display input
                break;
            }

            else if (ask == "3")
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
            }

            else if (ask == "4")
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
            }

        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {   
        int UserInput = 0;
        Journal journal = new Journal();

        do 
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            UserInput = int.Parse(Console.ReadLine());

            switch(UserInput)
            {
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;

            }

        } while (UserInput != 5);
    }

}
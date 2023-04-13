using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a six-digit ticket number: ");
        string ticketNumber = Console.ReadLine();

        if (ticketNumber.Length != 6)
        {
            Console.WriteLine("Invalid ticket number. Please enter exactly six digits.");
            return;
        }

        bool isLucky = IsTicketLucky(ticketNumber);

        if (isLucky)
        {
            Console.WriteLine("Congratulations! The ticket is lucky.");
        }
        else
        {
            Console.WriteLine("Sorry, the ticket is not lucky.");
        }
    }

    static bool IsTicketLucky(string ticketNumber)
    {
        int sumFirstThreeDigits = 0;
        int sumLastThreeDigits = 0;

        for (int i = 0; i < 3; i++)
        {
            int digit = int.Parse(ticketNumber[i].ToString());
            sumFirstThreeDigits += digit;
        }

        for (int i = 3; i < 6; i++)
        {
            int digit = int.Parse(ticketNumber[i].ToString());
            sumLastThreeDigits += digit;
        }

        return sumFirstThreeDigits == sumLastThreeDigits;
    }
}
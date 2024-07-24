namespace Concert_Management_System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        List<Ticket> tickets = new List<Ticket>();

        while (true)
        {
            Console.WriteLine("CHOOSE YOUR OPTION:");
            Console.WriteLine("1. Add Concert");
            Console.WriteLine("2. Add Festival");
            Console.WriteLine("3. Show Event");
            Console.WriteLine("4. Sell Ticket");
            Console.WriteLine("5. Exit");
            Console.Write("CHOICE: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    AddConcert(events);
                    break;
                case "2":
                    AddFestival(events);
                    break;
                case "3":
                    ShowEvent(events);
                    break;
                case "4":
                    SellTicket(events, tickets);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option! Try to choose the correct option.");
                    break;
            }
        }
    }

    static void AddConcert(List<Event> events)
    {
        Console.Write("Concert Name: ");
        string name = Console.ReadLine();
        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Artist Name: ");
        string artist = Console.ReadLine();

        events.Add(new Concert(name, date, artist));
        Console.WriteLine("Concert added successfully.\n");
    }

    static void AddFestival(List<Event> events)
    {
        Console.Write("Festival Name: ");
        string name = Console.ReadLine();
        Console.Write("Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Artist Names (separated by comma): ");
        string input = Console.ReadLine();
        string[] artists = input.Split(new[] { ", " }, StringSplitOptions.None);

        events.Add(new Festival(name, date, artists));
        Console.WriteLine("Festival added successfully.\n");
    }

    static void ShowEvent(List<Event> events)
    {
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetDetails());
        }
        Console.WriteLine();
    }

    static void SellTicket(List<Event> events, List<Ticket> tickets)
    {
        Console.Write("Event Name: ");
        string eventName = Console.ReadLine();
        Console.Write("Ticket Price: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Ticket ticket = new Ticket(eventName, price);
        ticket.SellTicket();
        tickets.Add(ticket);
        Console.WriteLine("Tickets sold successfully!\n");
    }
}

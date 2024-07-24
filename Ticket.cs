namespace Concert_Management_System;

public class Ticket : ISellable
{
    public string EventName { get; set; }
    public decimal Price { get; set; }

    public Ticket(string eventName, decimal price)
    {
        EventName = eventName;
        Price = price;
    }

    public void SellTicket()
    {
        Console.WriteLine($"Ticket for {EventName} sold at {Price:C}");
    }
}

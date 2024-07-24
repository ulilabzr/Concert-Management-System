namespace Concert_Management_System;

public abstract class Event
{
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Event(string name, DateTime date)
    {
        Name = name;
        Date = date;
    }

    public abstract string GetDetails();
}

namespace Concert_Management_System;

public class Concert : Event
{
    public string Artist { get; set; }

    public Concert(string name, DateTime date, string artist)
        : base(name, date)
    {
        Artist = artist;
    }

    public override string GetDetails()
    {
        return $"Concert: {Name}, Date: {Date.ToShortDateString()}, Artist: {Artist}";
    }
}

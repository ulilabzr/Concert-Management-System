namespace Concert_Management_System;

public class Festival : Event
{
    public string[] Artists { get; set; }

    public Festival(string name, DateTime date, string[] artists)
        : base(name, date)
    {
        Artists = artists;
    }

    public override string GetDetails()
    {
        return $"Festival: {Name}, Date: {Date.ToShortDateString()}, Artists: {string.Join(", ", Artists)}";
    }
}

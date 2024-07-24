namespace Concert_Management_System;

public class Artist
{
    public string Name { get; set; }
    public string Genre { get; set; }

    public Artist(string name, string genre)
    {
        Name = name;
        Genre = genre;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Artist: {Name}, Genre: {Genre}");
    }
}

using System; 
using dreamteam;

public class Karl : IDreamteam
{
    public string FirstName { get; set; } = "Karl";
    public string LastName { get; set; } = "Malone";
    public string Speciality { get; set; } = "Power Forward";
    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void work()
    {
        Console.WriteLine($"{FullName}, A/K/A The Mailman");
    }
}

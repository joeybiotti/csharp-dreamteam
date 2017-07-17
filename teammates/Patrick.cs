using System;
using dreamteam;


public class Patrick : IDreamteam
{
    public string FirstName { get; set; } = "Patric";
    public string LastName { get; set; } = "Ewing";
    public string Speciality {get; set; } = "Center";
    public string FullName {get => $"{this.FirstName} {this.LastName}";}
    public void work()
    {
        Console.WriteLine($"{FullName} went to Georgetown and played on the Knicks.");
    }
}

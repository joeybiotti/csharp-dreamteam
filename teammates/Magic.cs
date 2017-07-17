using System;
using dreamteam;

public class Magic : IDreamteam
{
    public string FirstName {get; set; } ="Magic";
    public string LastName { get; set; } = "Johnson";
    public string Speciality { get; set; }= "Point Guard";
    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void work()
    {
    Console.WriteLine($"{this.FirstName} wasn't as good as Bird");
    }
}


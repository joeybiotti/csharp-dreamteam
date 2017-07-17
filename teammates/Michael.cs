using System;
using dreamteam;

public class Michael : IDreamteam
{
    public string FirstName { get; set; } = "Michael";
    public string LastName { get;  set; } = "Jordan";
    public string Speciality {get; set; } = "Shooting Guard";
    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void work()
    {
    Console.WriteLine($"{this.FullName} was ALMOST as good as Bird");
    }
}
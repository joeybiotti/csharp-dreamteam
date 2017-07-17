using System; 
using dreamteam;

public class Larry : IDreamteam
{
    public string FirstName { get; set; } = "Larry";
    public string LastName { get; set; } = "Bird";
    public string Speciality { get; set; } = "Small Foward";
    public string FullName {get => $"{this.FirstName} {this.LastName}";}

    public void work()
    {
    Console.WriteLine($"{this.LastName} was the greatest ever.");
    }
}

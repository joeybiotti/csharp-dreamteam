using System; 
using dreamteam;


public class Joey : IDreamteam
{
    public string FirstName { get; set; } = "Joey";
    public string LastName { get; set; } = "Biotti";
    public string Speciality { get; set; } = "Veering outside of the exercise's instructions";
    public string FullName { get => $"{this.FirstName} {this.LastName}";}


    public void work()
    {
        Console.WriteLine($"{this.FirstName} barely remembers the 92 Dream Team.");
    }
}

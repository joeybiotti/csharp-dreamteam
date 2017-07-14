namespace dreamteam
{
    public interface IDreamteam
    {
        string FirstName { get; }
        string LastName { get; }
        string FullName { get; }
        string Speciality { get; }
        void work();
    }
}
using System; 

namespace dreamteam.Karl
{
    public class Karl : IDreamteam
    {
        public string FirstName => throw new NotImplementedException("Karl");

        public string LastName => throw new NotImplementedException("Malone");

        public string FullName => throw new NotImplementedException("Karl Malone");

        public string Speciality => throw new NotImplementedException("Power Forward");

        public void work()
        {
            Console.WriteLine("The Mailman");
        }
    }
}
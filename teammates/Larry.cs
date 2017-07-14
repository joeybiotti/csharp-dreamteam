using System; 

namespace dreamteam.Larry
{
    public class Larry : IDreamteam
    {
        public string FirstName => throw new NotImplementedException("Larry");

        public string LastName => throw new NotImplementedException("Bird");

        public string FullName => throw new NotImplementedException("Larry Bird");

        public string Speciality => throw new NotImplementedException("Small Foward");

        public void work()
        {
            Console.WriteLine("The greatest ever");
        }
    }
}
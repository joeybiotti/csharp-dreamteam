using System;

namespace dreamteam.Michael 
{
    public class Michael : IDreamteam
    {
        public string FirstName => throw new NotImplementedException("Michael");

        public string LastName => throw new NotImplementedException("Jordan");

        public string FullName => throw new NotImplementedException("Michael Jordan");

        public string Speciality => throw new NotImplementedException("Shooting Guard");

        public void work()
        {
            Console.WriteLine("The 2nd Greatest Ever");
        }
    }

}
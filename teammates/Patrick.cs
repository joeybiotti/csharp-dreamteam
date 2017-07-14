using System;

namespace dreamteam.Patrick
{
    public class Patrick : IDreamteam
    {
        public string FirstName => throw new NotImplementedException("Patric");

        public string LastName => throw new NotImplementedException("Ewing");

        public string FullName => throw new NotImplementedException("Patrick Ewing");

        public string Speciality => throw new NotImplementedException("Center");

        public void work()
        {
            Console.WriteLine("Went to Georgetown. Really smart.");
        }
    }
}
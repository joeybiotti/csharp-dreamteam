using System;

namespace dreamteam.Magic
{
    public class Magic : IDreamteam
    {
        public string FirstName => throw new NotImplementedException("Magic");

        public string LastName => throw new NotImplementedException("Johnson");

        public string FullName => throw new NotImplementedException("Irving 'Magic' Johnson");

        public string Speciality => throw new NotImplementedException("Point Guard");

        public void work()
        {
            Console.WriteLine("Magic wasn't as good as Bird");
        }
    }

}
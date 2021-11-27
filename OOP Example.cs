/////// OOP Example program.cs///////////



using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.firstName = "Md";
            personOne.middleName = "Noman";
            personOne.lastName = "Hasan";
            string fullName = personOne.GetFullName();
            string reverseName = personOne.GetReverseName();
            Console.WriteLine(reverseName);

            Person person2 = new Person();
            person2.firstName = "Mst";
            person2.middleName = "Mou";
            person2.lastName = "Akter";
            fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.ReadKey();
        }
    }
}

////////////person.cs//////////

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return (fullName);


        }
        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new String(charArray);

        }
 

    }
}




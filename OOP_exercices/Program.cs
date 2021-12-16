using System;

namespace OOP_exercices
{
    class Program
    {
        public class Persons
        {
            public int Age 
            {
                get; set;
            }
            public string LastName 
            { 
                get; set; 
            }
            public string FirstName 
            { 
                get; set; 
            }
            public string City
            {
                get; set;
            }
            public string Country
            {
                get; set;
            }

            public void PrintDataAboutPerson()
            {
                Console.WriteLine("Person information: ");
                Console.WriteLine(Age + " ani \n" + LastName + "\n" + FirstName + "\n" + City + "\n" + Country);
            }
        }

        static void Main(string[] args)
        {
            Persons Person1 = new Persons();
            Person1.Age = 20;
            Person1.FirstName = "Iosif";
            Person1.LastName = "Turcu";
            Person1.City = "Oradea";
            Person1.Country = "Romania";
            //com
            Person1.PrintDataAboutPerson();
        }
    }
}

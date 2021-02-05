 using System;

namespace Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer = new Costumer 
            {   
                Id=1,
                FirstName="Ali", 
                LastName="Kaygusuz", 
                City="Ankara"
            };

            Costumer costumer2 = new Costumer(2, "Yasemin", "Atakul", "Ankara");
            Console.WriteLine(costumer2.FirstName);

        }
    }

    class Costumer

    {
        public Costumer()
        {

        }   


        public Costumer(int id, String firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

    }
}

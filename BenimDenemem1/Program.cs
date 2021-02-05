using System;

namespace BenimDenemem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.Name = "Ali";
            person1.surName = "Kaygusuz";
            person1.age = 18;

            Console.WriteLine("Person 1 info: ", person1.Name);
            Person person2 = new Person();

            person2.Name = "Yasemin";
            Console.WriteLine("Person 2 info: ", person2);

            person2 = person1;
            Console.WriteLine("Değiştimi bakalım person 2 soyadı: ", person2.surName);
        }
    }
}

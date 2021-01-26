using System;

namespace ovn3_inkapsling_arv_poly_friman
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();
            /*
            Person person = new Person();
            try
            {
                person.FName = "Karl";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                person.LName = "Friman";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                person.Age = 42;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            person.Height = 197;
            person.Weight = 95;

            personHandler.SetAge(person, 43);
            */
            Person person2 = personHandler.CreatePerson(15, "John", "Smith", 140, 45);
            Person person3 = personHandler.CreatePerson(15, "Jack", "Johnson", 150, 55);

            personHandler.SetFName(person2,"Micke");
            Console.WriteLine(person2.Age);
            Console.WriteLine(person2.FName);
        }
    }
}

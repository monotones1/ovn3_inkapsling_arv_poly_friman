using System;

namespace ovn3_inkapsling_arv_poly_friman
{
    class Program
    {
        static void Main(string[] args)
        {

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
            PersonHandler personHandler = new PersonHandler();

            Person person2 = personHandler.CreatePerson(15, "John", "Smith", 140, 45);
            Person person3 = personHandler.CreatePerson(15, "Jack", "Johnson", 150, 55);

            personHandler.SetFName(person2,"Micke");
            Console.WriteLine(person2.Age);
            Console.WriteLine(person2.FName);

            //13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
            //vilken klass bör vi lägga det?
            //SVAR=I KLASSEN BIRD
            //14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            //SVAR=I KLASSEN ANIMAL

            Wolfman wolfMan1 = new Wolfman();
            Console.WriteLine(wolfMan1.Talk("The Wolfman speaks!")); 
        }
    }
}

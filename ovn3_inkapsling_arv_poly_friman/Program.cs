using System;
using System.Collections.Generic;

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

            personHandler.SetFName(person2, "Micke");
            //Console.WriteLine(person2.Age);
            //Console.WriteLine(person2.FName);

            //13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i
            //vilken klass bör vi lägga det?
            //SVAR=I KLASSEN BIRD
            //14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            //SVAR=I KLASSEN ANIMAL

            Wolfman wolfMan1 = new Wolfman("Vargmannen", 48, 145, true);
            Console.WriteLine(wolfMan1.Talk("The Wolfman speaks!"));
            Console.WriteLine("------");
            List<Animal> animals = new List<Animal>();

            animals.Add(new Wolf("Vargis", 10, 20, true));
            animals.Add(new Bird("Fåglis", 20, 30));    
            animals.Add(new Hedgehog("Igelkottis", 30, 40));
            animals.Add(new Wolfman("Vargmannen", 40, 50, true));
            animals.Add(new Dog("Hundis", 40, 50));

            foreach (Animal animal in animals)
            {
                String t = animal.GetType().Name;
                Console.WriteLine(t + ": " + animal.DoSound());
                if (animal is IPerson person)
                {
                    Console.WriteLine(t + ": " + person.Talk("Now it's time for an animal that is also an IPerson to speak."));
                }
            }
            Console.WriteLine("Antal objekt i listan animals: " + animals.Count);


            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("Hundett", 10, 20));
            dogs.Add(new Dog("Hundtvå", 10, 20));
            //9.F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            //dogs.Add(new Horse("Hundtre", 10, 20));
            //Den kan inte läggas där eftersom de inte har med varandra att göra i arvslistan och inte kan konverteras till den andra typen
            //10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans ?
            //Listan behöver vara instansierad som en "Animal" för att kunna ta alla typer av subkategorier
            Console.WriteLine("------");
            Console.WriteLine("Output all stats for the Animal objects in the animal list");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
            Console.WriteLine("Antal objekt i listan animals: " + animals.Count);
            //13. F: Förklara vad det är som händer.
            //Vi loopar igenom alla objekt som är instansierade i listan animals

            Console.WriteLine("------");
            Console.WriteLine("Output all dogs in the list dogs");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog.Stats());
            }
            //17. F: Varför inte?
            //Jag kommer inte åt den metoden för animals-listan eftersom den endast är tillgänglig i objekt som är skapade som Dogs.
            Console.WriteLine("------");
            Console.WriteLine("Output all dogs in the list animals");
            foreach (Animal animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.valfri());
                }
            }

            List<UserError> userErrors = new List<UserError>();
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new TrumpIsStupidError());
            userErrors.Add(new DownTheRabbitHoleError());
            userErrors.Add(new BadStepError());
            foreach (UserError error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
            //11. F: Varför är polymorfism viktigt att behärska?
            //För att kunna använda objekt på fler än ett sätt, i många (poly) former (morphism)
           // 12.F: Hur kan polymorfism förändra och förbättra kod via en bra struktur ?
           // När man går ner i kedjan kan man bli mer och mer specialiserad med overloads som behandlar det specifika
           //13.F : Vad är det för en skillnad på en Abstrakt klass och ett Interface?
           //Ett interface används i 9 fall av 10 eller ännu mer enligt Scott. Anledningen är t ex att en klass kan använda många interface
           //men den kan bara använda en abstrakt klass, med ett interface kan man bestämma funktionalitet utan att vara tvungen att implementera det,
           //en abstrakt klass kan ha konstruktor det kan inte ett interface ha.
        }
    }
}

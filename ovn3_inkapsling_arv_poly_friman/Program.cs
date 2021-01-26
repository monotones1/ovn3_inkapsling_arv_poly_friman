using System;

namespace ovn3_inkapsling_arv_poly_friman
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

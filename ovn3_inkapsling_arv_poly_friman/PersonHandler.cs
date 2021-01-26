using System;
using System.Collections.Generic;
using System.Text;

namespace ovn3_inkapsling_arv_poly_friman
{
    class PersonHandler
    {        
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;
            return person;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }

        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ovn3_inkapsling_arv_poly_friman
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        public int Age
        {
            get { return age; }
            set {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Age kan bara tilldelas ett värde större än 0.");

            } 
        }
        public string FName
        {
            get { return fName; }
            set {
                if (value.ToString().Length >= 2 && value.ToString().Length <= 10)
                    fName = value;
                else
                    throw new ArgumentException("FName är obligatorisk och får inte vara mindre än 2 tecken eller längre än 10 tecken.");
            } 
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.ToString().Length > 3 && value.ToString().Length <= 15)
                    lName = value;
                else
                    throw new ArgumentException("LName är obligatorisk och får inte vara mindre än 3 tecken eller större än 15 tecken.");
            }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; } 
        }

    }
}

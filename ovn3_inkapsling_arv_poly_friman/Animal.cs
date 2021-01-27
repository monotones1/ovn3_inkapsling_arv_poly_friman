using System;
using System.Collections.Generic;
using System.Text;

namespace ovn3_inkapsling_arv_poly_friman
{
    abstract class Animal
    {
        private string name;
        private int age;
        private double weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public virtual string DoSound()
        {
            return "Sound method called";
        }
        
        public virtual string Stats()
        {
            return $"Name: {name}. Age: {age.ToString()}. Weight: {weight.ToString()}.";
        } 
        
    }
    class Horse : Animal
    {
        private bool isTrotting;
        public Horse(string name, int age, double weight) : base(name, age, weight) { 
        
        }
        public bool IsTrotting
        {
            get { return isTrotting; }
            set { isTrotting = value; }
        }
        public override string DoSound()
        {
            return "Horse-speaker iiiiiiihhh";
        }
        public override string Stats()
        {
            return $"Horse is Trotting: {IsTrotting} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }

    }
    class Dog : Animal
    {
        private bool isBarking;
        public Dog(string name, int age, double weight) : base(name, age, weight)
        {

        }
        public bool IsBarking
        {
            get { return isBarking; }
            set { isBarking = value; }
        }
        public override string DoSound()
        {
            return "Dog-speaker voff voff";
        }
        public override string Stats()
        {
            return $"Dog is Barking: {IsBarking} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }
        public string valfri()
        {
            return ("Here is the dog you asked for.");
        }
    }
    class Hedgehog : Animal
    {
        private int numberOfSpikes;
        public Hedgehog(string name, int age, double weight) : base(name, age, weight)
        {

        }
        public int NumberOfSpikes
        {
            get { return numberOfSpikes; }
            set { numberOfSpikes = value; }
        }
        public override string DoSound()
        {
            return "Hedgehog-speaker badabing";
        }
        public override string Stats()
        {
            return $"Hedgehog number of spikes: {NumberOfSpikes} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }
    }
    class Worm : Animal
    {
        public Worm(string name, int age, double weight) : base(name, age, weight)
        {

        }
        private bool isUnderground;

        public bool IsUnderground
        {
            get { return isUnderground; }
            set { isUnderground = value; }
        }
        public override string DoSound()
        {
            return "Worm-speaker whazzap";
        }
        public override string Stats()
        {
            return $"Worm is Underground: {IsUnderground} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }

    }
    class Bird : Animal
    {
        public Bird(string name, int age, double weight) : base(name, age, weight)
        {

        }
        private double wingSpan;

        public double WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }
        public override string DoSound()
        {
            return "Bird-speaker pip pip";
        }
        public override string Stats()
        {
            return $"Bird Wing Span: {WingSpan} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }
    }

    class Wolf : Animal
    {

        private bool isHowling;
        public Wolf(string name, int age, double weight, bool isHowling) : base(name, age, weight)
        {
            IsHowling = isHowling;
        }
        public bool IsHowling
            {
            get { return isHowling; }
            set { isHowling = value; }
        }
        public override string DoSound()
        {
            return "Wolf howling oohooohh";
        }
        public override string Stats()
        {
            return $"Wolf is Howling: {IsHowling} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }
    }
    class Pelican : Bird
    {
        public Pelican(string name, int age, double weight) : base(name, age, weight)
        {

        }
        private bool isPelecanusOnocrotalus;
        public bool IsPelecanusOnocrotalus
        {
            get { return isPelecanusOnocrotalus; }
            set { isPelecanusOnocrotalus = value; }
        }
        public override string Stats()
        {
            return $"Pelican is Pelecanus Onocrotalus: {IsPelecanusOnocrotalus} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }
    }
    class Flamingo : Bird
    {
        public Flamingo(string name, int age, double weight) : base(name, age, weight)
        {

        }
        private bool isPinkAndBeautiful;

        public bool IsPinkAndBeautiful
        {
            get { return isPinkAndBeautiful; }
            set { isPinkAndBeautiful = value; }
        }
        public override string Stats()
        {
            return $"Flamingo is Pink And Beautiful: {IsPinkAndBeautiful} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }
    }
    class Swan : Bird
    {
        public Swan(string name, int age, double weight) : base(name, age, weight)
        {

        }
        private bool isCygnusCygnus;
        public bool IsCygnusCygnus
        {
            get { return isCygnusCygnus; }
            set { isCygnusCygnus = value; }
        }
        public override string Stats()
        {
            return $"Flamingo is Cygnus Cygnus: {isCygnusCygnus} Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }
    }

    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight, bool isHowling) : base(name, age, weight, isHowling)
        {

        }
        public string Talk(string sentence)
        {
            return sentence;
        }
    }
}

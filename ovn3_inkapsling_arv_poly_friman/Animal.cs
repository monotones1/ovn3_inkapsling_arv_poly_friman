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
        public Animal()
        {

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
            return $"Name: {base.Name}. Age: {base.Age}. Weight: {base.Weight}.";
        }

    }
    class Dog : Animal
    {
        private bool isBarking;

        public bool IsBarking
        {
            get { return isBarking; }
            set { isBarking = value; }
        }
        public override string DoSound()
        {
            return "Dog-speaker voff voff";
        }
    }
    class Hedgehog : Animal
    {
        private int numberOfSpikes;

        public int NumberOfSpikes
        {
            get { return numberOfSpikes; }
            set { numberOfSpikes = value; }
        }
        public override string DoSound()
        {
            return "Hedgehog-speaker badabing";
        }
    }
    class Worm : Animal
    {
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

    }
    class Bird : Animal
    {
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
    }

    class Wolf : Animal
    {
        private bool isHowling;

        public bool IsHowling
            {
            get { return isHowling; }
            set { isHowling = value; }
        }
        public override string DoSound()
        {
            return "Wolf howling oohooohh";
        }
    }
    class Pelican : Bird
    {
        private bool isPelecanusOnocrotalus;
        public bool IsPelecanusOnocrotalus
        {
            get { return isPelecanusOnocrotalus; }
            set { isPelecanusOnocrotalus = value; }
        }

    }
    class Flamingo : Bird
    {
        private bool isPinkAndBeautiful;

        public bool IsPinkAndBeautiful
        {
            get { return isPinkAndBeautiful; }
            set { isPinkAndBeautiful = value; }
        }

    }
    class Swan : Bird
    {
        private bool isCygnusCygnus;
        public bool IsCygnusCygnus
        {
            get { return isCygnusCygnus; }
            set { isCygnusCygnus = value; }
        }
    }

    class Wolfman : Wolf, IPerson
    {
        public string Talk(string sentence)
        {
            return sentence;
        }
    }
}

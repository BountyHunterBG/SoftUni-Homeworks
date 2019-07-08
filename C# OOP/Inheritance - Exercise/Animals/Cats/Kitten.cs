﻿namespace Animals
{
    public class Kitten : Cat
    {
        const string gender = "Female";
        public Kitten(string name, int age)
            : base(name, age, gender)
        {

        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
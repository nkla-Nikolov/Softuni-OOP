﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Country { get; set; }

        public string GetName(string name)
        {
            return name;
        }

        public string GetName()
        {
            return "Mr/Ms/Mrs";
        }

    }
}

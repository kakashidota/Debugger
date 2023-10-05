using System;
using System.Collections.Generic;

namespace Debugger
{
    abstract class Human
    {
        public string Name { get; set; }

        public abstract void DisplayDetails();
    }

    class Doctor : Human
    {
        public string Specialty { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Doctor {Name}, specializes in {Specialty}.");
        }
    }

    class Engineer : Human
    {
        public string Field { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Engineer {Name}, works in {Field}.");
        }
    }

    class Artist : Human
    {
        public string ArtForm { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Artist {Name}, creates {ArtForm}.");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Human> humans = new List<Human>
            {
                new Doctor { Name = "Dr. Smith", Specialty = "Cardiology" },
                new Engineer { Field = "Software Engineering" }, 
                new Artist { Name = "Bob", ArtForm = "Dancing" },
            };

            foreach (var human in humans)
            {
                human.DisplayDetails();
            }
        }
    }
}

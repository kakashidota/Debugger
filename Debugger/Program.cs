using System;
using System.Collections.Generic;

namespace Debugger
{
    using System;
    using System.Collections.Generic;

    public abstract class Human
    {
        public string Name { get; set; }
        public abstract string DailyRoutine();
    }

    class Doctor : Human
    {
        public override string DailyRoutine()
        {
            return $"{Name} checks the patient list, consults patients, and writes prescriptions.";
        }
    }

    class Engineer : Human
    {
        public override string DailyRoutine()
        {
            return $"{Name} reviews blueprints, attends project meetings, and drafts designs.";
        }
    }

    class Artist : Human
    {
        public string Medium { get; set; }  // e.g. "paint", "clay", "digital tools"

        public override string DailyRoutine()
        {
            return $"{Name} gets inspired by using {Medium}, creates artwork, and attends art showcases.";
        }
    }

    class Program
    {
        static void Main()
        {
            var humans = new List<Human>
        {
            new Doctor { Name = "Dr. Smith" },
            new Engineer { Name = "Diana" },
            new Artist { Name = "Leonardo" }
        };


            List<Human> alsoHumans = new List<Human>();
            Doctor doctor = new Doctor();
            doctor.Name = "Franky";
            alsoHumans.Add(doctor);
            Engineer engo = new Engineer();
            engo.Name = "Felicia";
            Artist artist = new Artist();
            artist.Name = "John";
            alsoHumans.Add(artist);

            Console.WriteLine("Daily Routines:");
            foreach (var human in humans)
            {
                Console.WriteLine(human.DailyRoutine());
            }

            foreach (Human humano1 in alsoHumans)
            {
                Console.WriteLine(humano1.DailyRoutine());
            }
            //}
        }

    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Teacher:Person
    {
        public double Experience { get; set; }


        public Teacher(string name, string surName, int age, double experience) : base(name, surName, age)
        {
            Experience = experience;
        }

        public override void ShowFullData()
        {
            Console.WriteLine($"NAme: {Name} Surname: {SurName} Age: {Age} Experience {Experience}");
        }
    }
}

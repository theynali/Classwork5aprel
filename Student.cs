using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8
{
    internal class Student : Person
    {
        public double Point { get; set; }


        public Student(string name, string surName, int age, double point) : base(name, surName, age)
        {
            Point = point;
        }

        public override void ShowFullData()
        {
            Console.WriteLine($"NAme: {Name} Surname: {SurName} Age: {Age} Point: {Point}");
        }
    }   }

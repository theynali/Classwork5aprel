using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8
{
    abstract class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }


        public Person(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;

        }
        public virtual void SayFullName()
        {
            Console.WriteLine(Name+SurName);
        }
        public abstract void ShowFullData();
    }
  
   
}

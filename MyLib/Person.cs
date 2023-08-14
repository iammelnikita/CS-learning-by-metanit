using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Person
    {
        private string name = "Undefined";

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }

        private int age;

        public int Age
        {
            /*get
            {
                return age;
            }*/
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Incorrect entered age value");
                }
                else
                {
                    age = value;
                }
            }
        }

        public Person()
        {
            name = "Undefined";
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name};\nAge: {age};\n");
        }

        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Show1stLstName()
        {
            Console.WriteLine($"First name: {firstName};\nLast name: {lastName};\n");
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

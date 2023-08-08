using System.Reflection.Metadata.Ecma335;

namespace MyLib
{
    public class Enemy
    {
        string name;
        int damage;

        public Enemy(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public string Name
        {
            get //only for reading
            {
                return name;
            }
        }

        public int Damage
        {
            get
            {
                return damage;
            }
            set 
            {
                if (value > 0 && value <= 30)
                {
                    damage = value;
                }
                else
                {
                    Console.WriteLine("Damage should be from 0 to 30");
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Enemy \"{name}\" has {damage} damage.");
        }
    }

    public class Person
    {
        string lastName = "";
        string firstName = "";
        string middleName = "";
        string name = "";

        public string Name
        {
            get
            {
                return name == "" ? $"{lastName} {firstName} {middleName}" : name;
            }

            private set
            {
                name = value;
            }
        }

        public Person(string lastName, string firstName, string middleName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            name = "";
        }

        public Person(string name)
        {
            this.name = name;
            lastName = "";
            firstName = "";
            middleName = "";
        }

        public int age = 0;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string AutoName { get; set; } = "";

        public int AutoAge { get; set; } = 0;

        public Person(string name, int age)
        {
            AutoName = name;
            AutoAge = age;
        }
    }

    public struct ValueType
    {
        public int x;
        public int y;
        public ReferenceType reference;

        public ValueType()
        {
            x = 0;
            y = 0;
            reference = new ReferenceType();
        }
    }

    public class ReferenceType
    {
        public int x;
        public int y;
    }
}
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
            get
            {
                return name;
            }
            set
            {
                name = value;
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
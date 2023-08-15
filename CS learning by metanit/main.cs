using MyLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Overload();
    }

    public static void Overload()
    {
        Calculator calc = new Calculator();

        Console.WriteLine(calc.Add(1232, 123));
    }

    public static void Properties()
    {
        string name = "Nikita";
        int age = 20;
        Person person = new Person(name, age);
        //person.Name = "Nikita";
        //person.Age = 20;
        Console.WriteLine($"Person(\"{name}\", {age})");
        person.ShowInfo();

        string firstName = "Nikita";
        string lastName = "Melnik";
        Person person_2 = new Person(firstName, lastName);
        Console.WriteLine($"Person(\"{firstName}\", \"{lastName}\")");
        person_2.Show1stLstName();
    }
}
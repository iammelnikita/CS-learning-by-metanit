using MyLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Enemy madDog = new Enemy("Mad dog", 10);

        madDog.Name = "mad dog";
        Console.WriteLine(madDog.Name);
        madDog.ShowInfo();

        Console.WriteLine();

        Console.WriteLine(madDog.Damage);

        madDog.Damage = 100; //Damage should be from 0 to 30

        Console.WriteLine(madDog.Damage); 
    }
    
    public static void ReferenceAndValueType()
    {
        MyLib.ValueType value1 = new MyLib.ValueType(); // ValueType  - structure: its data located in stack
        MyLib.ValueType value2 = new MyLib.ValueType();
        value2.x = 1;
        value2.y = 2;
        value2.reference.x = 31;

        value1 = value2;
        value2.x = 5;
        value2.reference.x = 32;

        Console.WriteLine($"value1.x-y-reference.x {value1.x} {value1.y} {value1.reference.x}, value2.x-y-reference.x {value2.x} {value2.y} {value2.reference.x}\n");

        ReferenceType reference1 = new ReferenceType(); // ReferenceType - class: reference at heap is placed in stack
        ReferenceType reference2 = new ReferenceType(); // All object data placed at heap
        reference2.x = 1;
        reference2.y = 2;

        reference1 = reference2;
        reference2.y = 7;

        Console.WriteLine($"reference1.x-y {reference1.x} {reference1.y}, value2.x-y {reference2.x} {reference2.y}\n");

        ChangeReferenceType(ref reference2);

        Console.WriteLine($"reference2: {reference2.x} {reference2.y}");
    }

    public static void ChangeReferenceType(ref ReferenceType reference)
    {
        reference.x = 20; //working

        reference = new ReferenceType // working at this method only
        {
            x = 47,
            y = 100
        };

        Console.WriteLine($"reference: {reference.x} {reference.y}");
    }
}
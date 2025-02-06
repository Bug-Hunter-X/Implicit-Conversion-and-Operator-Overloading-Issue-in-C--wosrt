public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(ExampleClass example)
    {
        return example.MyProperty;
    }

    public static implicit operator ExampleClass(int value)
    {
        return new ExampleClass(value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ExampleClass obj1 = new ExampleClass(10);
        int num1 = obj1; // Implicit conversion from ExampleClass to int
        Console.WriteLine(num1); // Output: 10

        int num2 = 20;
        ExampleClass obj2 = num2; // Implicit conversion from int to ExampleClass
        Console.WriteLine(obj2.MyProperty); // Output: 20

        ExampleClass obj3 = 30; //Implicit conversion from int to ExampleClass
        ExampleClass obj4 = obj3 + obj2;// Implicit conversion from int to ExampleClass and then uses the + operator which is not defined for ExampleClass type
        Console.WriteLine(obj4.MyProperty); // Output: Compilation Error. Cannot implicitly convert type 'int' to 'ExampleClass'. An explicit conversion exists (are you missing a cast?)
    }
}
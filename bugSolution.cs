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

    // Overload the + operator for ExampleClass
    public static ExampleClass operator +(ExampleClass a, ExampleClass b)
    {
        return new ExampleClass(a.MyProperty + b.MyProperty);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ExampleClass obj1 = new ExampleClass(10);
        int num1 = obj1; 
        Console.WriteLine(num1); 

        int num2 = 20;
        ExampleClass obj2 = num2; 
        Console.WriteLine(obj2.MyProperty); 

        ExampleClass obj3 = 30; 
        ExampleClass obj4 = obj3 + obj2; 
        Console.WriteLine(obj4.MyProperty); // Output: 50
    }
}
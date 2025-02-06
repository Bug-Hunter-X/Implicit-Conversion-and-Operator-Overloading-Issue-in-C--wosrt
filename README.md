# Implicit Conversion and Operator Overloading Issue in C#

This example demonstrates a potential issue when using implicit user-defined type conversions in C# along with operators that haven't been overloaded for the custom type.  The implicit conversion can mask the problem, leading to unexpected compilation errors or runtime exceptions.

The `bug.cs` file shows code that uses implicit conversion between an `ExampleClass` and `int`. While the individual conversions work fine, combining them with the addition operator (`+`) results in a compilation error. This is because the `+` operator is not overloaded for `ExampleClass`, and the implicit conversion from the result of the addition (which is an `int`) back to `ExampleClass` is not automatically done.

The `bugSolution.cs` file offers a solution by explicitly defining the + operator or any other operator which is used in the code for the ExampleClass type.
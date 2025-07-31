# C#

C# is a modern, object-oriented programming language developed by Microsoft. It is widely used for building Windows applications, web services, and games. C# combines the power of C++ with the simplicity of Visual Basic, making it a versatile choice for developers.
C# supports strong typing, garbage collection, and a rich set of libraries, which allows developers to create robust and efficient applications. It is part of the .NET framework, which provides a comprehensive environment for building and running applications across different platforms.

## Variables and (Primitives) Data Types

In C#, variables are used to store data, and each variable has a specific data type that determines the kind of data it can hold. The most common primitive data types in C# include:

- `int`: Represents a 32-bit signed integer.
- `float`: Represents a single-precision floating-point number.
- `double`: Represents a double-precision floating-point number.
- `char`: Represents a single 16-bit Unicode character.
- `bool`: Represents a Boolean value (`true` or `false`).
- `string`: Represents a sequence of characters (text).
- `decimal`: Represents a 128-bit precise decimal value, suitable for financial calculations.

## Operators

C# supports a variety of operators that allow you to perform operations on variables and values. These
operators include:

- **Arithmetic Operators**: `+`, `-`, `*`, `/`, `%` for basic mathematical operations.
- **Comparison Operators**: `==`, `!=`, `<`, `>`, `<=`, `>=` for comparing values.
- **Logical Operators**: `&&`, `||`, `!` for logical operations.
- **Assignment Operators**: `=`, `+=`, `-=`, `*=`, `/=`, `%=` for assigning values to variables.
- **Bitwise Operators**: `&`, `|`, `^`, `~`, `<<`, `>>` for bit-level operations.
- **Conditional Operator**: `? :` for inline conditional expressions.

## Control Flow

C# provides several control flow statements that allow you to control the execution of your code based on
conditions. These include:

- **if**: Executes a block of code if a specified condition is true.
- **else**: Executes a block of code if the condition in the `if` statement is false.
- **else if**: Allows you to check multiple conditions in sequence.
- **switch**: Selects a block of code to execute based on the value of an expression.
- **for**: Executes a block of code a specified number of times.
- **while**: Repeats a block of code as long as a specified condition is true.
- **do while**: Similar to `while`, but guarantees that the block of code is executed at least once before checking the condition.
- **foreach**: Iterates over a collection or array, executing a block of code for each element.

## Functions

Functions in C# are blocks of code that perform a specific task and can be reused throughout your program. They can take parameters and return values. The syntax for defining a function is as follows:

```csharp
returnType FunctionName(parameterType parameterName)
{
    // Function body
    return value; // Optional return statement
}
```

Functions can be called by their name, and you can pass arguments to them. C# also supports method overloading, allowing you to define multiple functions with the same name but different parameter types or counts.

## Classes and Objects

C# is an object-oriented programming language, which means it allows you to define classes and create objects. A class is a blueprint for creating objects, encapsulating data and behavior. The syntax for defining a class is as follows:

```csharp
class ClassName
{
    // Fields (variables)
    private int field;

    // Constructor
    public ClassName(int value)
    {
        field = value;
    }

    // Method
    public void MethodName()
    {
        // Method body
    }
}
```

You can create an object of a class using the `new` keyword:

```csharp
ClassName obj = new ClassName(42);
```

Objects can access the fields and methods of their class using the dot notation:

```csharp
obj.MethodName();
```

## Inheritance

C# supports inheritance, allowing you to create a new class that inherits properties and methods from an existing class. The existing class is called the "base class," and the new class is called the "derived class." The derived class can extend or modify the behavior of the base class.

Here's an example:

```csharp
class BaseClass
{
    public void BaseMethod()
    {
        // Base method implementation
    }
}

class DerivedClass : BaseClass
{
    public void DerivedMethod()
    {
        // Derived method implementation
    }
}
```

In this example, `DerivedClass` inherits from `BaseClass`, meaning it has access to the `BaseMethod` and can also define its own methods.

## Polymorphism

Polymorphism in C# allows you to use a single interface to represent different underlying forms (data types). This is achieved through method overriding and interfaces. Method overriding allows a derived class to provide a specific implementation of a method that is already defined in its base class.
Here's an example:

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}
```

In this example, both `Dog` and `Cat` classes override the `Speak` method of the `Animal` class. When you call the `Speak` method on an `Animal` reference that points to a `Dog` or `Cat` object, the appropriate method is executed based on the actual object type.

## Interfaces

Interfaces in C# define a contract that classes can implement. An interface specifies a set of methods
and properties that a class must implement, without providing the implementation itself. This allows for a form of multiple inheritance, as a class can implement multiple interfaces.
Here's an example of defining and implementing an interface:

```csharp
interface IAnimal
{
    void Speak();
}
class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}
```

In this example, both `Dog` and `Cat` classes implement the `IAnimal` interface, providing their own implementations of the `Speak` method. You can use an `IAnimal` reference to call the `Speak` method on either a `Dog` or a `Cat` object.

## Exception Handling

C# provides a robust exception handling mechanism that allows you to handle runtime errors gracefully. You can use `try`, `catch`, and `finally` blocks to manage exceptions. The `try` block contains code that may throw an exception, the `catch` block handles the exception, and the `finally` block executes code that runs regardless of whether an exception occurred.
Here's an example:

```csharp
try
{
    // Code that may throw an exception
    int result = 10 / 0; // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Cannot divide by zero: " + ex.Message);
}
finally
{
    Console.WriteLine("This block always executes.");
}
```

In this example, if a `DivideByZeroException` occurs, the catch block will handle it, and the finally block will execute regardless of whether an exception was thrown or not.

## Collections

C# provides several built-in collection types that allow you to store and manage groups of related objects. Some commonly used collections include:

- **Array**: A fixed-size collection of elements of the same type.
- **List&lt;T&gt;**: A dynamic array that can grow and shrink in size, allowing you to add or remove elements.
- **Dictionary<TKey, TValue>**: A collection of key-value pairs, where each key is unique and maps to a value.
- **HashSet&lt;T&gt;**: A collection that contains unique elements and provides fast lookups.
- **Queue&lt;T&gt;**: A first-in, first-out (FIFO) collection that allows you to enqueue and dequeue elements.
- **Stack&lt;T&gt;**: A last-in, first-out (LIFO) collection that allows you to push and pop elements.

## Recursion

Recursion is a programming technique where a function calls itself to solve a problem. In C#, recursion can be used to solve problems that can be broken down into smaller sub-problems. A recursive function typically has a base case that stops the recursion and a recursive case that continues the recursion.
Here's an example of a simple recursive function that calculates the factorial of a number:

```csharp
int Factorial(int n)
{
    if (n == 0)
        return 1;
    return n * Factorial(n - 1);
}
```

In this example, the `Factorial` function calls itself with a smaller value of `n` until it reaches the base case where `n` is 0. The recursion unwinds, and the final result is returned.

## Structs

Structs in C# are similar to classes but are value types rather than reference types. They are used to encapsulate small groups of related variables and methods. Structs are typically used for lightweight objects that do not require the overhead of a class.
Here's an example of defining a struct:

```csharp
struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}
```

In this example, the `Point` struct has two fields, `X` and `Y`, and a constructor to initialize them. You can create an instance of a struct using the `new` keyword:

```csharp
Point p = new Point(10, 20);
```

Structs can be used to group related data together, and they are often used in scenarios where performance is critical, as they are allocated on the stack rather than the heap.

## Enums

Enums in C# are a special data type that allows you to define a set of named constants. Enums are used to represent a collection of related values, making your code more readable and maintainable. Each value in an enum is assigned an underlying integer value by default, starting from 0.
Here's an example of defining an enum:

```csharp
enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
```

You can use an enum in your code like this:

```csharp
DaysOfWeek today = DaysOfWeek.Monday;
Console.WriteLine("Today is: " + today);
```

In this example, the `DaysOfWeek` enum defines the days of the week, and you can assign a specific day to a variable of type `DaysOfWeek`. Enums improve code clarity by providing meaningful names for related constants, making it easier to understand the purpose of the values used in your code.

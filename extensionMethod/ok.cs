// C# program to illustrate the concept
// of the extension methods
using System;

namespace ExtensionMethod;

class Geek
{

    // Method 1
    public void M1()
    {
        Console.WriteLine("Method Name: M1");
    }

    // Method 2
    public void M2()
    {
        Console.WriteLine("Method Name: M2");
    }

    // Method 3
    public void M3()
    {
        Console.WriteLine("Method Name: M3");
    }

}


//===================================================
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person()
    {

    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }



}


using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John", "Doe");
        Console.WriteLine("Full Name in Uppercase: " + person.FullName);
    }
}

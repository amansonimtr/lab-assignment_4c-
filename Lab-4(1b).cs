public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string FullName
    {
        get { return $"{FirstName} {LastName}".ToUpper(); }
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

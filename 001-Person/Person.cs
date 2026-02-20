class Person
{
    public Person(string personName, int personAge)
    {
        Name = personName;
        Age = personAge;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }
}
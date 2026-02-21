class Repository
{
    private Person[] people;
    private int count;
    private int index = 0;
    public Repository(int count)
    {
        this.count = count;
        people = new Person[count];
    }
    #region Практическая работа 13.4
    public void Append(Person person)
    {
        try
        {
            people[index] = person;
            index++;
        }
        catch (Exception)
        {
            Console.WriteLine($"Выход за рамки созданного хранилища, допустимая вместимость {count} элементов.");
        }
    }
    #endregion

    public void Print()
    {
        for (int i = 0; i < this.index; i++)
        {
            Person temp = people[i];
            Console.WriteLine($"Name: {temp.Name} Age: {temp.Age}");
        }
    }
}
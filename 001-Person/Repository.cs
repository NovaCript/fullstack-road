using System.Linq.Expressions;

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

    // public int Index { get { return index; } }
    // public int Index { get => index; }
    public int Count => index;

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

    public Person GetPersonById(int id)
    {
        return (id < 0 || id >= index)
        ? new Person("empty", -1)
        : people[id];
    }

}
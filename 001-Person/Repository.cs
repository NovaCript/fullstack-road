using System.Linq.Expressions;

class Repository
{
    private Person[] storage;
    private int count;
    private int index = 0;
    public Repository(int count)
    {
        this.count = count;
        storage = new Person[count];
    }

    // public int Index { get { return index; } }
    // public int Index { get => index; }
    public int Count => index;

    public void Append(params Person[] people)
    {
        foreach (var person in people)
        {
            try
            {
                storage[index] = person;
                index++;
            }
            catch (Exception)
            {
                Console.WriteLine($"Выход за рамки созданного хранилища, допустимая вместимость {count} элементов.");
            }
        }
    }

    public Person GetPersonById(int id)
    {
        return (id < 0 || id >= index)
        ? new Person("empty", -1)
        : storage[id];
    }

}
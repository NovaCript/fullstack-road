class Printer
{
    public void Print(Repository repository)
    {
        int max = repository.Count;

        for (int i = 0; i < max; i++)
        {
            Person temp = repository.GetPersonById(i);
            Console.WriteLine($"Name : {temp.Name}, Age : {temp.Age}");
        }

    }
}

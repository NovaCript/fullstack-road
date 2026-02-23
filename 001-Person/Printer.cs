class Printer
{
    public void Print(Repository repository)
    {
        int max = repository.Count;

        for (int i = 0; i < max; i++)
        {
            Console.WriteLine(repository.GetPersonById(i).ToString());
        }

    }
}

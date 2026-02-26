interface IRepo<T>
{
    int Count { get; }
    void Append(params T[] people);
    public Person GetById(int id);
}

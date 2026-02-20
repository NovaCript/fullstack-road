// пользователи - имя возраст
// добавить в базу
// прочитать 
// распечатать

public class Person
{

    public string Name { get; }
    public int Age { get; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Print()
    {
        Console.WriteLine($$"""
        {
          "name": "{{Name}}",
          "age": {{Age}}
        }
    """);
    }
}
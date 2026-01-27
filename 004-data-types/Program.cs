using System.Dynamic;

int integerNumber = 42;

double floatingPointNumber = 3.14;

bool boolearValue = true;

char character = 'A';

string name = "John";

// Особый тип данных
object anyType = "Это строка";
anyType = 10; // теперь число

Point p1 = new Point(10, 20);
p1.Display();

Person person = new Person("Gleb", 31);
person.SayHello();
System.Console.WriteLine($"{person.Age}, {person.Name}");
person.Name = "Semen";
System.Console.WriteLine(person.Name);


Week today = Week.Monday;
System.Console.WriteLine(today);
enum Week { Monday, Tuesday, Wednesday }

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age { get => age;}

    public void SayHello()
    {
        Console.WriteLine($"Hello my name is {name}, my age is {age}");
    }

}
public struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public void Display() => Console.WriteLine("$X: {X}, Y: {Y}");

}

var myTuple = (1, true, "hello");
Console.WriteLine($"{myTuple.Item1}, {myTuple.Item2}, {myTuple.Item3}");

var (number, flag, word) = myTuple;
Console.WriteLine($"{number}, {flag}, {word}");

var namedTuple = (Name: "Nova", Greeting: "hello", Age: 30);
Console.WriteLine($"{namedTuple.Greeting}, {namedTuple.Name}, {namedTuple.Age}");



var person1 = new Person("John", "Doe");
Console.WriteLine($"{person1.FirstName}");
Console.WriteLine($"{person1.LastName}");
var person2 = new Person("John", "Doe");

Console.WriteLine($"Record сравнение - равны ли person1 и person2: {person1 == person2}");

var person3 = person1 with {LastName = "Smith"};
Console.WriteLine($"Клонирование и модификация record - новая фамилия: {person3.LastName}");

public record Person(string FirstName, string LastName);

// Person person1 = new("Gleb I.", 31);
Person person1 = new Person("Gleb I.", 31);
Person person2 = new Person("Lena E.", 29);
// Console.WriteLine($$"""
// Person{ Name : {{person1.GetName()}}, Age : {{person1.GetAge()}}}
// """);
// person1.SetAge(120);
// Console.WriteLine($$"""
// Person{ Name : {{person1.GetName()}}, Age : {{person1.GetAge()}}}
// """);

// person1.Age = 120;
// Console.WriteLine($"{person1.Age}");
// Console.WriteLine($"{person1.Name}");

Repository repository = new Repository(10);

repository.Append(person1);
repository.Append(person2);
repository.Print();

for (int i = 0; i < 11; i++)
{
    repository.Append(person1);
}

repository.Print();
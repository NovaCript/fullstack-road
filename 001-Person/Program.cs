
const string LINE = ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>";
// Person person1 = new("Gleb I.", 31);
// Person person1 = new Person("Gleb I.", 31);
// Person person2 = new Person("Lena E.", 29);
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

// Repository repository = new Repository(10);

// repository.Append(person1);
// repository.Append(person2);
// repository.Print();

// for (int i = 0; i < count; i++)
// {
//     CreatePerson($"Name {i}", Random.Shared.Next(10, 80));
//     PrintPersonById(i);
// }

// Repository repository = new Repository(10);
// for (int i = 0; i < 10; i++)
// {
//     repository.Append(new Person($"Человек{i}", Random.Shared.Next(10, 80)));
// }

// Person res1 = repository.GetPersonById(5);

// Console.WriteLine($"Name : {res1.Name},  Age : {res1.Age}");

// Person res2 = repository.GetPersonById(-1);
// Person res3 = repository.GetPersonById(10);


// Console.WriteLine($"{res2.Name}, {res2.Age}");
// Console.WriteLine($"{res3.Name}, {res3.Age}");

// Console.WriteLine($"{LINE}");
// Printer printer = new Printer();
// printer.Print(repository);

// Console.WriteLine($"{LINE}");

// Repository newPeople = new Repository(10);
// printer.Print(newPeople);

// Person person10 = new Person("a", 10);
// Person person11 = new Person("b", 22);
// Person person12 = new Person("c", 43);

// Person[] arrayPerson = { person10, person11, person12 };
// newPeople.Append(arrayPerson);
// newPeople.Append(person10, person11, person12);

// printer.Print(newPeople);

// Console.WriteLine($"{LINE}");

Student student = new Student("Petya", 18, "School # 322");
Console.WriteLine(student.ToString());

Console.WriteLine($"{LINE}");

Employee employee = new Employee("Test1", 77, 2000);
Console.WriteLine(employee.ToString());

Console.WriteLine($"{LINE}");

Teacher teacher = new Teacher("Nova", 33, "Informatics");
Console.WriteLine(teacher.ToString());


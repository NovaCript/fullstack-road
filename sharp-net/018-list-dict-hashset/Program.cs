using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

List<int> list = new List<int>();
List<string> list2 = new ();

list.Add(1);
list.Add(2);
list.Add(1);
list.Add(5);
Console.WriteLine($"{String.Join(", ", list)}");

list.RemoveAt(0); // удалит элемент на 0 индексе
list.Remove(2); // удалит первое включение 2
list[0] = 123; // установит на 0 индекс значение 123

Console.WriteLine($"{String.Join(", ", list)}");

// ---------------------------------------------------------------------------

// Dictionary<int, string> users = new Dictionary<int, string>();
Dictionary<int, string> users = new()
{
    {1, "Nova"},
    {2, "Cript"}
};

users.Add(3, "Bob");
users[4] = "Alice";

// foreach (KeyValuePair<int, string> pair in users)
foreach (var pair in users)
{
    Console.WriteLine($"ID: {pair.Key} - Value: {pair.Value}");
}


foreach (var item in users.Values)
{
    Console.WriteLine($"{item}");
}

// ---------------------------------------------------------------------------

HashSet<int> numbers = new HashSet<int>() {1,2,3,4,5,6};

numbers.Add(7);

numbers.Remove(2); // удаление элемента по значению

foreach (var item in numbers)
{
    Console.WriteLine($"{item}");
}

HashSet<int> set1 = new HashSet<int>() {1,2,3,4,5};
HashSet<int> set2 = new HashSet<int>() {4,5,6,7,8};

set1.IntersectWith(set2);
Console.WriteLine($"Пересечение множеств set1 & set2:");
foreach (int value in set1)
{
    Console.Write($"[{value}]");
}
Console.WriteLine($"");

set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
set1.UnionWith(set2);
Console.WriteLine($"Объединение множеств set1 & set2:");
foreach (int value in set1)
{
    Console.Write($"[{value}]");
}
Console.WriteLine($"");


set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
set1.ExceptWith(set2);
Console.WriteLine($"Исключение из set1 содержимого в set2:");
foreach (int value in set1)
{
    Console.Write($"[{value}]");
}
Console.WriteLine($"");
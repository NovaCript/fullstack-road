string hello = "Hello, ";
string world = "world!";
string combined = String.Concat(hello, world);
Console.WriteLine($"{combined}");

bool containsWorld = combined.Contains("world");
Console.WriteLine($"Строка содержит 'world': {containsWorld}");

// 0 1 2 3 4 5 6 7 8 9 . . .
// H e l l o ,   w o r l d !
int indexOfW = combined.IndexOf('w');
Console.WriteLine($"{indexOfW} позиция символа 'w'");

string sub = combined.Substring(7);
// Подстрока с индекса 7 до конца строки
Console.WriteLine($"{sub}");

// Пример использования Replace заменяемый|подмена
string replaced = combined.Replace("world", "C#");
// Вывод: Hello, C#!
// Изначальная строка не меняется, так как string неизменяемый значимый тип
Console.WriteLine($"Измененная строка: {replaced}\nОригинальная строка: {combined}");

// Пример разделения строки на элементы | Символ разделитель ','
string[] parts = "one, two, three".Split(',');
foreach (string item in parts)
    Console.WriteLine($"[{item}]");

Console.WriteLine($"{parts[0]} -> 0 индекс");

string upper = combined.ToUpper();
Console.WriteLine($"{upper}");
string lower = upper.ToLower();
Console.WriteLine($"{lower}");

//               Удаляет пробелы с начала и с конца
string trimmed = "          He    llo, w o rld!   ".Trim();
Console.WriteLine($"Удаляет пробелы с начала и с конца: [{trimmed}]");

int lengthString = combined.Length;
Console.WriteLine($"Длинна строки: {lengthString}");

bool areEqual = String.Equals("Hello", "hello", StringComparison.OrdinalIgnoreCase);
// Сравнение без учета регистра
Console.WriteLine($"Строки равны (без учета регистра): {areEqual}");


string c = Convert.ToString(combined[1]);
Console.WriteLine($"{c.GetType().Name}");
c = combined[1].ToString();
Console.WriteLine($"{c.GetType().Name}");
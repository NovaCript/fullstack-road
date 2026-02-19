using System.Text;

// Пример использования StringBuilder для конкатенации строк

StringBuilder sb = new StringBuilder();

sb.Append("Hello, ");
sb.Append("world");
sb.Append("!");
sb[1] = '!';

string greeting = sb.ToString();
Console.WriteLine($"{sb}");

